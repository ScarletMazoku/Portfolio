<?php
   require "db.php";

   $data = $_POST;
   $showError = false;
   $emailAble = true;

   $user = R::findOne('users', 'id = ?', array($_SESSION['user']->id));
   if($user)
   {
      header('location: index.php');
   }
   else
   {
      if(isset($data['isLogin']))
      {
         //авторизуемся
         $errors =array();
         $showError = true;

         if(trim($data['email']) == '')
         {
            $errors[] = 'Введите email!';
         }
         
         if($data['password'] == '')
         {
            $errors[] = 'Введите пароль!';
         }
         
         if(empty($errors))
         {
            $user = R::findOne('users', 'email = ?', array($data['email']));

            if($user)
            {
               //логин существует

               if(password_verify($data['password'], $user->password))
               {
                  //все хорошо, логиним пользователя
                  $_SESSION['user'] = $user;
                  if($user->status == "admin")
                  {
                     header('location: admin.php#users');
                  }
                  else
                  {
                     header('location: index.php');
                  }  
               }
               else
               {
                  $errors[] = 'Пароль введен не верно!';
               }
            }
            else
            {
               $errors[] = 'Пользователь с такой почтой не найден!';
               $emailAble = false;
               
            }
         }
         $user = R::findOne('users', 'id = ?', array($_SESSION['user']->id));
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
   <title>MPEI | Авторизация</title>
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
            <form action="login.php" class="form" method="POST">
               <div class="form__top">
                  <div class="form__title">Авторизация</div>
               </div>
               <div class="form__content">
                  <div class="form__item">
                     <input type="email" class="form__input" placeholder="Email" name="email" value="<?php if($emailAble) {echo $_POST["email"];}?>">
                     <div class="form__input-image">
                        <img src="img/reg form/email-icon.png" alt="">
                     </div>
                  </div>
                  <div class="form__item">
                     <input type="password" class="form__input" placeholder="Пароль" name="password">
                     <div class="form__input-image">
                        <img src="img/reg form/lock-icon.png" alt="">
                     </div>
                  </div>
                  <div class="form__item">
                     <div class ="form__errormsg"><?php if($showError) {echo showErrors($errors);}?></div>
                     <button type="submit" class="form__button" name="isLogin">Войти</button>
                  </div>
               </div>
               <div class="form__bottom">
                  <span class="form__span">Нет аккаунта?</span>
                  <a href="signup.php" class="form__link-reg">Регистрация</a>
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
</body>
</html>
