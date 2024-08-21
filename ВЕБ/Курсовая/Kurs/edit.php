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
      $userPhoto = $_FILES['userPhoto'];

      if(isset($data['isSave']))
      {
         $errors = array();
         $showError = true;

         if(trim($data['userFirstname']) == '')
         {
            $errors[] = 'Введите имя!';
         }

         if(trim($data['userLastname']) == '')
         {
            $errors[] = 'Введите Фамилию!';
         }
         if(userPhotoSecurity($userPhoto))
         {
            alert("фото поменялось!");
            $user->avatar = loaduserPhoto($userPhoto);
         }
         if(empty($errors))
         {
            $user->firstname = $data['userFirstname'];
            $user->lastname = $data['userLastname'];
            $user->info = $data['userAbout'];

            if($data['userSkillsCoding'] == '')
            {
               $user->skillCoding = 0;
            }
            else
            {
               $user->skillCoding = $data['userSkillsCoding'];
            }

            if($data['userSkillsPhotoshop'] == '')
            {
               $user->skillPhotoshop = 0;
            }
            else
            {
               $user->skillPhotoshop = $data['userSkillsPhotoshop'];
            }

            if($data['userSkillsVideoediting'] == '')
            {
               $user->skillVideoediting = 0;
            }
            else
            {
               $user->skillVideoediting = $data['userSkillsVideoediting'];
            }
         
            R::store($user);           
         }
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
   <title>MPEI | Редактирование профиля</title>
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
            <div class="edit__title title">Редактирование профиля</div>
            <form action="edit.php" class="form__edit" method="post" enctype="multipart/form-data">
               <div class="edit__content">
                  <div class="edit__left">
                     <div class="edit__avatar-container">
                        <div class="edit__avatar ibg">
                           <img src="uploads/avatars/<?php echo $user->avatar;?>" alt="Ваше фото">
                        </div>

                        <div class="edit__photo">
                           <input type="file" accept=".png, .jpg, .jpeg" class="edit__photo-input" id="user-photo" name="userPhoto" value="1">
                           <label for="user-photo" class="edit__photo-label">Изменить фото</label>
                        </div>
                     </div>

                     <div class="edit__photo-preview" id="user-photo-preview"></div>
                     <div class="edit__items">
                        <div class="edit__item">                        
                           <button type="submit" name="isSave" class="btn button__save">Сохранить</button>  
                        </div>
                        <div class="edit__item">
                           <a href="user.php" class="btn button__back">Назад</a>
                        </div>
                     </div>                 
                  </div>
                  <div class="edit__right">
                     <div class="edit__name">
                        <h2 class="edit__title">Имя:</h2>
                        <div class="edit__items">
                           <div class="edit__item">
                              <label for="userFirstname"></label>
                              <input type="text" class="edit__input" name="userFirstname" id="userFirstname" value="<?php echo $user->firstname;?>">           
                           </div>
                        </div>
                     </div>
                     
                     <div class="edit__email">
                        <h2 class="edit__title">Фамилия:</h2>
                        <div class="edit__items">
                           <div class="edit__item">
                              <label for="userLastname"></label>                       
                              <input type="text" class="edit__input" name="userLastname" id="userLastname" value="<?php echo $user->lastname?>">                        
                           </div>
                        </div>
                     </div>
                     <div class="edit__about">
                        <h2 class="edit__title">О себе:</h2>
                        <div class="edit__items">
                           <div class="edit__item">
                              <label for="user-about"></label>
                              <textarea name="userAbout" id="user-about" cols="30" rows="10" class="user__textarea"><?php echo $user->info?></textarea>
                           </div>
                        </div>
                     </div>
                     <div class="edit__slills">
                        <h2 class="edit__title">Навыки:</h2>
                        <div class="edit__items">
                           <div class="edit__item">
                              <div class="checkbox">
                                 <input type="checkbox" class="checkbox__input" id="user-skills-videoediting" name="userSkillsVideoediting" value="1" <?php if($user->skillVideoediting != 0) echo "checked";?>>
                                 <label class="checkbox__label" for="user-skills-videoediting">Монтаж видео</label>
                              </div>
                           </div>
                           <div class="edit__item">
                              <div class="checkbox">
                                 <input type="checkbox" class="checkbox__input" id="user-skills-photoshop" name="userSkillsPhotoshop" value="1" <?php if($user->skillPhotoshop != 0) echo "checked";?>>
                                 <label class="checkbox__label" for="user-skills-photoshop">Знание фотошопа</label>
                              </div>
                           </div>
                           <div class="edit__item">
                              <div class="checkbox">
                                 <input type="checkbox" class="checkbox__input" id="user-skills-coding" name="userSkillsCoding" value="1" <?php if($user->skillCoding != 0) echo "checked";?>>
                                 <label class="checkbox__label" for="user-skills-coding">Программирование</label>
                              </div>
                           </div>
                        </div>
                     </div>
                     <div class ="form__errormsg form__errormsg-edit"><?php if($showError) {echo showErrors($errors);}?></div>
                  </div>
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
