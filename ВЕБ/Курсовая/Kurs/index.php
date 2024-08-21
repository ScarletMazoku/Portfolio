<?php
   require "db.php";
   $user = R::findOne('users', 'id = ?', array($_SESSION['user']->id));
?>
<!DOCTYPE html>
<html lang="en">

<head>
   <meta charset="UTF-8">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <link rel="stylesheet" href="css/style.css">
   <title>MPEI</title>
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
         </div>

         <div class="container">
            <div class="main__title">M P E I</div>
            <div class="main__subtitle">База анкет соискателей</div>
            <div class="features">
               <div class="features__item">
                  <img src="img/feachers/1.png" class="features__icon"></img>
                  <h4 class="features__title">Прокачивай навыки</h4>
                  <div class="features__text">Прокачивай навыки и приступай к заказам. Чем больше ты умеешь, тем больше вакансий тебе доступны.</div>
               </div>
               <div class="features__item">
                  <img src="img/feachers/2.png" class="features__icon"></img>
                  <h4 class="features__title">Строй карьеру</h4>
                  <div class="features__text">Откликайся на доступные какансии и развивайся.</div>
               </div>
               <div class="features__item">
                  <img src="img/feachers/2.png" class="features__icon"></img>
                  <h4 class="features__title">Работай из дома</h4>
                  <div class="features__text">Тебе не обязательно ехать в офис. Работай в свое удовольствие прямо из дома, бери заказы и зарабатывай.</div>
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
