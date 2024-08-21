<?php
   require "db.php";
   $data = $_POST;
   $showError = false;

   $user = R::findOne('users', 'id = ?', array($_SESSION['user']->id));
   if($user)
   {
      header('location: index.php');
   }
   else
   {
      if(isset($data['isSignup']))
      {
         //регистрируемся

         $errors = array();
         $showError = true;

         if(trim($data['firstname']) == '')
         {
            $errors[] = 'Введите имя!';
         }

         if(trim($data['lastname']) == '')
         {
            $errors[] = 'Введите фамилию!';
         }
         
         if(trim($data['email']) == '')
         {
            $errors[] = 'Введите email!';
         }
         
         if($data['password_1'] == '')
         {
            $errors[] = 'Введите пароль!';
         }

         if($data['password_2'] != $data['password_1'])
         {
            $errors[] = 'Пароли не совпадают!';
         }

         if(R::count('users', 'email = ?', array($data['email'])) > 0)
         {
            $errors[] = 'Пользователь с таким email уже есть.';
         }

         if(empty($errors))
         {
            //можно зарегистрировать
            $user = R::dispense('users');
            $user->firstname = $data['firstname'];
            $user->lastname = $data['lastname'];
            $user->email = $data['email']; 
            $user->password = password_hash($data['password_1'], PASSWORD_DEFAULT);
            $user->avatar = "default.jpg"; 
            $user->status = "user";
            $user->info = "";
            $user->skillCoding = 0; 
            $user->skillPhotoshop = 0;
            $user->skillVideoediting = 0;
            $user->completeCount = 0;
            
            R::store($user);

            $_SESSION['user'] = $user;
            header('location: /');
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
   <title>MPEI | Регистрация</title>
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
            <form action="signup.php" class="form" method="POST">
               <div class="form__top">
                  <div class="form__title">Регистрация</div>
               </div>
               <div class="form__content">
               <div class="form__item">
                     <input type="text" class="form__input" placeholder="Имя" name="firstname" value="<?php echo $_POST["firstname"];?>">
                  </div>
                  <div class="form__item">
                     <input type="text" class="form__input" placeholder="Фамилия" name="lastname" value="<?php echo $_POST["lastname"];?>">
                  </div>
                  <div class="form__item">
                     <input type="email" class="form__input" placeholder="Email" name="email" value="<?php echo $_POST["email"];?>">
                  </div>
                  <div class="form__item">
                     <input type="password" class="form__input" placeholder="Пароль" name="password_1">
                  </div>
                  <div class="form__item">
                     <input type="password" class="form__input" placeholder="Повторите пароль" name="password_2">
                  </div>
                  <div class="form__item">
                     <div class ="form__errormsg"><?php if($showError) echo showErrors($errors);?></div>
                     <button type="submit" class="form__button" name="isSignup">Зарегистрироваться</button>
                  </div>
               </div>
               <div class="form__bottom">
                  <span class="form__span">Есть аккаунт?</span>
                  <a href="login.php" class="form__link-reg">Войти</a>
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
