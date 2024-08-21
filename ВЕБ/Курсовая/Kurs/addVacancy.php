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
      $showError = false;
   
      if(isset($data['isAdd']))
      {
         //регистрируемся
         $errors = array();
         $showError = true;
   
         if(trim($data['vacancyTitle']) == '')
         {
            $errors[] = 'Введите название объявления!';
         }
   
         if(trim($data['vacancyInfo']) == '')
         {
            $errors[] = 'Добавьте описание объявления!';
         }
         if(($data['vacancySkillsVideoediting'] == "") && ($data['vacancySkillsPhotoshop'] == "") && ($data['vacancySkillsCoding'] == ""))
         {
            $errors[] = 'Выберете хотя бы один навык!';
         }
         if(empty($errors))
         {
            //можно зарегистрировать
            $vacancy = R::dispense('vacancies');
            $vacancy->user_id = $user->id;
            $vacancy->title = $data['vacancyTitle']; 
            $vacancy->info = $data['vacancyInfo'];
            if($data['vacancySkillsCoding'])
            {
               $vacancy->skillCoding = $data['vacancySkillsCoding'];
            }
            else
            {
               $vacancy->skillCoding = 0;
            }
            if($data['vacancySkillsPhotoshop'])
            {
               $vacancy->skillPhotoshop = $data['vacancySkillsPhotoshop'];
            }
            else
            {
               $vacancy->skillPhotoshop = 0;
            }
            if($data['vacancySkillsVideoediting'])
            {
               $vacancy->skillVideoediting = $data['vacancySkillsVideoediting'];
            }
            else
            {
               $vacancy->skillVideoediting = 0;
            }  
   
            $vacancy->isComplete = 0;
            
            R::store($vacancy);
            header('location: user.php');
         }
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
   <title>MPEI | Добавить вакансию</title>
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
            <form action="addVacancy.php" class="addVacancy__form" method="POST">
               <div class="form__top">
                  <div class="form__title">Новое объявление</div>
               </div>
               <div class="form__content-vac">
                  <div class="addVacancy__top">
                     <div class="addVacancy__name">
                        <h2 class="addVacancy__title">Название:</h2>
                        <div class="edit__items">
                           <div class="edit__item">
                              <label for="vacancyTitle"></label>
                              <input type="text" class="vacancyTitle__input" name="vacancyTitle" id="vacnancyTitle" value="<?php echo $_POST["vacancyTitle"];?>">
                           </div>
                        </div>
                     </div>

                     <div class="addVacancy__skills">
                        <h2 class="addVacancy__title">Навыки:</h2>
                        <div class="edit__items">
                           <div class="edit__item">
                              <div class="checkbox">
                                 <input type="checkbox" class="checkbox__input" id="user-skills-videoediting" name="vacancySkillsVideoediting" value="1">
                                 <label class="checkbox__label" for="user-skills-videoediting">Монтаж видео</label>
                              </div>
                           </div>
                           <div class="edit__item">
                              <div class="checkbox">
                                 <input type="checkbox" class="checkbox__input" id="user-skills-photoshop" name="vacancySkillsPhotoshop" value="1">
                                 <label class="checkbox__label" for="user-skills-photoshop">Знание фотошопа</label>
                              </div>
                           </div>
                           <div class="edit__item">
                              <div class="checkbox">
                                 <input type="checkbox" class="checkbox__input" id="user-skills-coding" name="vacancySkillsCoding" value="1">
                                 <label class="checkbox__label" for="user-skills-coding">Программирование</label>
                              </div>
                           </div>
                        </div>
                     </div>
                  </div>
                                                         
                  <div class="addVacancy__description">
                     <h2 class="addVacancy__title">Описание:</h2>
                     <div class="edit__items">
                        <div class="edit__item">
                           <label for="vacancyInfo"></label>
                           <textarea name="vacancyInfo" id="vacancyInfo" cols="30" rows="10" class="addVacancy__textarea"><?php echo $_POST["vacancyInfo"];?></textarea>
                        </div>
                     </div>
                  </div>

                  <div class="addVacancy__buttons">
                     <div class ="form__errormsg form__errormsg-vac"><?php if($showError) echo showErrors($errors);?></div>
                     <button type="submit" name="isAdd" class="btn button__add">Добавить</button>
                     <a href="user.php" class="btn button__back-vac">Отмена</a>
                  </div>
               </div>
               <div class="form__bottom-vac">
               </div>
            </form>
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
