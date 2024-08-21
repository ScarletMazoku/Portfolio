<?php
   require "db.php";

   $user = R::findOne('users', 'id = ?', array($_SESSION['user']->id));
   if(!($user))
   {
      header('location: login.php');
   }
   else
   {
      if($user->status != "admin")
      {
         header('location: user.php');
      }
      else
      {
         $data = $_POST;
         if( isset($data['deleteVacancyUsers']) )
         {
            $id = $data['vacancyNumberUsers'];
            R::getAssoc('DELETE FROM vacancies WHERE id = ?', [$id]);
            header('location: admin.php#users');
         }
         if( isset($data['deleteVacancyVacancies']) )
         {
            $id = $data['vacancyNumberVacancies'];
            R::getAssoc('DELETE FROM vacancies WHERE id = ?', [$id]);
            header('location: admin.php#vacancies');
         }
         if( isset($data['isDeleteUser']) )
         {
            $id = $data['deleteUserNumber'];
            R::getAssoc('DELETE FROM users WHERE id = ?', [$id]);
            header('location: admin.php#users');
         }
      }
   }
?>
<!DOCTYPE html>
<html lang="en">
<head>
   <meta charset="UTF-8">
   <link rel="stylesheet" href="css/style.css">
   <title>MPEI | Admin</title>
</head>
<body>
   <div class="wrapper">
      <div class="admin__tabs tabs">
         <div class="tabs__items">
            <div class="tabs__items-top">
               <a href="#users" class="tabs__item"><span>Пользователи</span></a>
               <a href="#vacancies" class="tabs__item"><span>Вакансии</span></a>
               <div class="tabs_position"></div>
            </div>
            <div class="tabs__items_bottom">
               <a href="logout.php" class="button__admin-exit">Выйти</a>
            </div>   
         </div>
         <div class="admin__body">
            <div id="users" class="tabs__block">
               <div class="admin__title title">Пользователи</div>
                  <?php
                     $users = R::getAll('SELECT * FROM users WHERE status != "admin"');

                     foreach($users as $item) :
                  ?>
                  
                     <div class="user__title title">Пользователь №<?php echo $item['id']?></div>
                     <div class="user">
                        <div class="user__content">
                           <div class="user__left">
                              <div class="edit__avatar ibg">
                                 <img src="uploads/avatars/<?php echo $item['avatar'];?>" alt="Ваше фото">
                              </div>
                              <form action="admin.php" class="deleteUser" method="POST">
                                 <input type="number" name="deleteUserNumber" class="btn deleteUser__number" value="<?php echo $item['id']?>">
                                 <button type="submit" name="isDeleteUser" class="btn deleteUser__button">Удалить</button>
                              </form>
                           </div>
                           <div class="user__info">
                              <div class="user__name">
                                 <h2 class="name__title subtitle">Имя и фамилия:</h2>
                                 <p class="name__text"><?php echo $item['firstname'] . " " . $item['lastname']?></p>
                              </div>
                              <div class="user__name">
                                 <h2 class="email__title subtitle">Электронная почта:</h2>
                                 <p class="email__text"><?php echo $item['email']?></p>
                              </div>
                              <div class="user__about">
                                 <h2 class="about__title subtitle">информация о пользователе:</h2>
                                 <p class="about__text"><?php echo $item['info']?></p>
                              </div>
                              <div class="user__skills">
                                 <h2 class="skills__title subtitle">Навыки пользователя:</h2>

                                 <?php if(($item['skill_coding'] == 0) && ($item['skill_photoshop'] == 0) && ($item['skill_videoediting'] == 0)) :?>
                                    <div class="skills__list listTypeNone">
                                       <li>У вас нет навыков</li>
                                 <?php else :?>
                                    <div class="skills__list">
                                 <?php endif;?>
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
                           </div>
                        </div>
                        <?php $vacancies = R::getAll('SELECT * FROM vacancies WHERE is_complete = 0 AND user_id = ? ', [$item['id']]);?>
                        <?php if(!($vacancies)) :?>
                           <div class="user__title title">У пользователя нет объявлений</div>
                        <?php else : ?>
                        <div class="user__title title">Объявления пользователя</div>
                        <div class="user__vacancies">
                           <div class="vacancies__items">

                           <?php
                              
                              if(count)               
                              foreach($vacancies as $item) :
                              ?>

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
                                    <form action="admin.php" method="POST" class="">
                                       <input type="text" name="vacancyNumberUsers" class="form_deletevacancy-input" value="<?php echo $item['id'];?>">
                                       <button name="deleteVacancyUsers" class="vacancies__cross">
                                          <span class="vacancies__cross-item"></span>
                                       </button>
                                    </form>
                                 </div>
                              </div>
                           <?php endforeach?>
                           </div>

                        </div>
                        <?php endif;?>
                     </div>
                     <?php endforeach?>
                  
            </div>
            <div id="vacancies" class="tabs__block">
               <div class="admin__title title">Вакансии</div>

               <?php
                  $vacancies = R::getAll('SELECT * FROM vacancies WHERE is_complete = 0');
                  foreach($vacancies as $item1) :
                  $result1 = R::findOne( 'users', 'id = ?', [$item1['user_id']] );
               ?>

               <div class="vacancies__item" id="vacancies__item-<?php echo $item1['id'];?>">
                  <div class="acancies__item-left">
                     <div class="vacancies__item-img ibg">
                        <img src="uploads/avatars/<?php echo $result1["avatar"];?>" alt="">
                     </div>   
                  </div>
                  <div class="vacancies__item-content">
                     <div class="vacancies__item-title"><?php echo $item1['title'];?></div>
                     <div class="vacancies__item-username"><?php echo $result1["firstname"] . " " . $result1["lastname"]?></div>
                     <span class="greenline"></span>
                     <div class="vacancies__skills">
                        <div class="vacancies__skills-title">Необходимые навыки:</div>
                        <div class="vacancies__skills-title-list">
                           <?php
                              if($item1['skill_coding'] != 0)
                              {
                                 echo "<li>Программирование</li>";
                              }
                              if($item1['skill_photoshop'] != 0)
                              {
                                 echo "<li>Знание фотошопа</li>";
                              }
                              if($item1['skill_videoediting'] != 0)
                              {
                                 echo "<li>Монтаж видео</li>";
                              }
                           ?> 
                        </div>
                     </div>
                     <div class="vacancies__item-text"><h4>Инормация:</h4><?php echo $item1['info'];?></div>
                     <form action="admin.php" method="POST" class="">
                        <input type="text" name="vacancyNumberVacancies" class="form_deletevacancy-input" value="<?php echo $item1['id'];?>">
                        <button name="deleteVacancyVacancies" type="submit" class="vacancies__cross">
                           <span class="vacancies__cross-item"></span>
                        </button>
                     </form>
                  </div>
               </div>
               <?php endforeach?>
               
            </div>
         </div>
      </div>
   </div>
   <script src="js/script.js"></script>
</body>
</html>
