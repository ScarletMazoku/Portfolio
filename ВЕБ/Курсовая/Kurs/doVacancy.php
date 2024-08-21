<?php
   require "db.php";
   $user = R::findOne('users', 'id = ?', array($_SESSION['user']->id));

   $data = $_POST;
  if( isset($data['isDoVacancy']) )
  {
   $id = $data['vacancyNumber'];

   $vacancy = R::findOne( 'vacancies', 'id = ?', [$id] );
   $vacancy['is_complete'] = 1;
   R::store($vacancy);

   $user = R::findOne( 'users', 'id = ?', array($_SESSION['user']->id) );
   $user['complete_count'] += 1;
   R::store($user);
   }
   header('location: user.php');
?>
