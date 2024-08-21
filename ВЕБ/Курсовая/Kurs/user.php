<?php
   require "db.php";
   $user = R::findOne('users', 'id = ?', array($_SESSION['user']->id));
   if(!($user))
   {
      header('location: login.php');
   }
   else
   {
      $data = $_POST;
      if( isset($data['deleteVacancy']) )
      {
         $id = $data['vacancyNumber'];
         R::getAssoc('DELETE FROM vacancies WHERE id = ?', [$id]);
         header('location: user.php');
       }
   }
?>

<!DOCTYPE html>
<html lang="en">

<head>
   <meta charset="UTF-8">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <link rel="stylesheet" href="css/style.css">
   <title>MPEI | Личный кабинет</title>
</head>

<body>
   <div class="wrapper">

   <header class="header">
         <div class="header__container container">
            <div class="header__left">
               <?php if($user) :?>
                  <a href="user.php" class="header__avatar ibg">
                     <img src="uploads/avatars/<?php echo $user->avatar;?>" alt="Ваше фото">
                  </a>
                  <a href="user.php" class="header__username"><?php echo $user->firstname . " " . $user->lastname?></a>
               <?php else : ?>
                  <a href="index.php" class="header__logo">M P E I</a>
               <?php endif; ?>            
            </div>
            <div class="header__right">
               <nav class="header__nav">
                  <ul class="header__list">
                     <li>
                        <a href="index.php" class="header__link">Главная</a>
                     </li>
                     <li>
                        <a href="user.php" class="header__link">Профиль</a>
                     </li>
                     <li>
                        <a href="vacancies.php" class="header__link">Вакансии</a>
                     </li>
                  </ul>
               </nav>
               <div class="header__login">
                  <?php if($user) :?>
                     <a href="logout.php" class="header__button log__button">Выйти</a>
                  <?php else :?>
                     <a href="login.php" class="header__button log__button">Войти</a>
                     <a href="signup.php" class="header__button reg__button">Регистрация</a>
                  <?php endif;?> 
               </div>
            </div>
         </div>
      </header>

      <main class="main">
         <div class="main__container container">
            <div class="user__title title">Личный кабинет</div>
            <div class="user">
               <div class="user__content">
                  <div class="user__left">
                     <div class="edit__avatar ibg">
                        <img src="uploads/avatars/<?php echo $user->avatar;?>" alt="Ваше фото">
                     </div>
                     <a href="edit.php" class="btn button__change">Редактировать</a>
                     <a href="logout.php" class="btn button__logout">Выйти</a>
                  </div>
                  <div class="user__info">
                     <div class="user__name">
                        <h2 class="name__title subtitle">Имя и фамилия:</h2>
                        <p class="name__text"><?php echo $user->firstname . " " . $user->lastname?></p>
                     </div>
                     <div class="user__name">
                        <h2 class="email__title subtitle">Электронная почта:</h2>
                        <p class="email__text"><?php echo $user->email?></p>
                     </div>
                     <div class="user__about">
                        <h2 class="about__title subtitle">О себе:</h2>
                        <?php if($user->info == ""):?>
                           <p class="about__text">Нет информации. Расскажите о себе.</p>
                        <?php else :?>
                           <p class="about__text"><?php echo $user->info?></p>
                        <?php endif;?>
                     </div>
                     <div class="user__skills">
                        <h2 class="skills__title subtitle">Навыки:</h2>

                        <?php if(($user->skillCoding == 0) && ($user->skillPhotoshop == 0) && ($user->skillVideoediting == 0)) :?>
                           <div class="skills__list listTypeNone">
                              <li>У вас нет навыков</li>
                        <?php else :?>
                           <div class="skills__list">
                        <?php endif;?>
                           <?php
                           if($user->skillCoding != 0)
                           {
                              echo "<li>Программирование</li>";
                           }
                           if($user->skillPhotoshop != 0)
                           {
                              echo "<li>Знание фотошопа</li>";
                           }
                           if($user->skillVideoediting != 0)
                           {
                              echo "<li>Монтаж видео</li>";
                           }
                           ?>          
                        </div>
                     </div>
                     <div class="user__completeCount">
                        <h2 class="skills__title subtitle">Кол-во выполненных заказов: <?php echo $user->completeCount;?></h2>
                     </div>
                  </div>
               </div>
               <div class="user__title title">Мои объявления</div>
               <div class="button__addVacancy-container">
                  <a href="addVacancy.php" class="btn button__addVacancy">Добавить</a>
               </div>
               <div class="user__vacancies">
                  <?php $vacancies = R::getAll('SELECT * FROM vacancies WHERE is_complete = 0 AND user_id = ? ', array($_SESSION['user']->id))?>
                     <?php if(!($vacancies)) :?>
                        <div class="user__title-nv subtitle">У Вас нет объявлений</div>
                     <?php else : ?>
                  <div class="vacancies__items">
                     <?php foreach($vacancies as $item) :?>
                        <div class="vacancies__item">
                           <div class="vacancies__item-content">
                              <div class="vacancies__item-title"><?php echo $item['title'];?></div>
                              <span class="greenline"></span>
                              <div class="vacancies__skills">
                                 <div class="vacancies__skills-title">Необходимые навыки:</div>
                                 <div class="vacancies__skills-title-list">
                                    <?php
                                       if($item['skill_coding'] != 0)
                                       {
                                          echo "<li>Программирование</li>";
                                       }
                                       if($item['skill_photoshop'] != 0)
                                       {
                                          echo "<li>Знание фотошопа</li>";
                                       }
                                       if($item['skill_videoediting'] != 0)
                                       {
                                          echo "<li>Монтаж видео</li>";
                                       }
                                    ?> 
                                 </div>
                              </div>
                              <div class="vacancies__item-text"><h4>Инормация:</h4><?php echo $item['info'];?></div>
                              <form action="user.php" method="POST" class="">
                                 <input type="text" name="vacancyNumber" class="form_deletevacancy-input" value="<?php echo $item['id'];?>">
                                 <button name="deleteVacancy" class="vacancies__cross">
                                    <span class="vacancies__cross-item"></span>
                                 </button>
                              </form>
                           </div>
                        </div>
                     <?php endforeach?>
                     </div>
                  <?php endif;?>
               </div>
            </div>
         </div>
      </main>

      
      <footer class="footer">
         <div class="footer__container container">
            <div class="footer__content">Все права защищены © 2022</div>
         </div>
      </footer>
   </div>
   <script src="js/script.js"></script>
</body>
</html>
