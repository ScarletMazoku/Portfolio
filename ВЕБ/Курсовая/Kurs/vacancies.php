<?php
   require "db.php";
   $user = R::findOne('users', 'id = ?', array($_SESSION['user']->id));
   if(!($user))
   {
      header('location: login.php');
   }
?>
<!DOCTYPE html>
<html lang="en">

<head>
   <meta charset="UTF-8">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <link rel="stylesheet" href="css/style.css">
   <title>MPEI | Вакансии</title>
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
         <div class="vacancies__title title">Вакансии</div>          
            <?php
               $vacancies = R::getAll('SELECT * FROM vacancies WHERE is_complete = 0 AND user_id != ? ', array($_SESSION['user']->id));
               foreach($vacancies as $item) :
                  $result = R::findOne( 'users', 'id = ?', [$item['user_id']] );
            ?>

            <div class="vacancies__item" id="vacancies__item-<?php echo $item['id'];?>">
               <div class="acancies__item-left">
                  <div class="vacancies__item-img ibg">
                     <img src="uploads/avatars/<?php echo $result["avatar"];?>" alt="">
                  </div>
                  <?php if(checkSkills($item["skill_coding"], $item["skill_photoshop"], $item["skill_videoediting"])):?>
                     <form action="doVacancy.php" class="form__doVacancy" method="POST">
                        <input type="text" name="vacancyNumber" class="vacancies_button-number" value="<?php echo $item['id'];?>">
                        <button class="vacancies_button-do btn" type="submit" name="isDoVacancy">Выполнить</button>
                     </form>
                  <?php else :?>
                     <form action="doVacancy.php" class="form__doVacancy" method="POST">
                        <input type="text" name="vacancyNumber" class="vacancies_button-number" value="<?php echo $item['id'];?>">
                        <button disabled class="vacancies_button-disabled btn" type="submit" name="isDoVacancy">Выполнить</button>
                     </form>
                  <?php endif;?>
               </div>
               <div class="vacancies__item-content">
                  <div class="vacancies__item-title"><?php echo $item['title'];?></div>
                  <div class="vacancies__item-username"><?php echo $result["firstname"] . " " . $result["lastname"]?></div>
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
               </div>
            </div>
         <?php endforeach?>
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
