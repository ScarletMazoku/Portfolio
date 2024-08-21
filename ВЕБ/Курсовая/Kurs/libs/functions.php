<?php
   function alert($msg) {
      echo "<script type='text/javascript'>alert('$msg');</script>";
   }

   function showErrors($errors){
      return array_shift($errors);
   }

   function userPhotoSecurity($userPhoto){
      $name = $userPhoto['name'];
      $type = $userPhoto['type'];
      $size = $userPhoto['size'];

      $blacklist = array('html', 'php', 'js');

      foreach($blacklist as $row)
      {
         if(preg_match("/$row\$/i", $name))
            return false;
      }

      if(($type != "image/png") && ($type != "image/jpeg") && ($type != "image/jpg"))
         return false;
      
      if($size > 10 * 1024 * 1024)
         return false;

      return true;
   }
   function loaduserPhoto($userPhoto){
      $type = $userPhoto['type'];
      $name = md5(microtime()). '.' . substr($type, strlen("image/"));
      $dir = "uploads/avatars/";
      $uploadfile = $dir . $name;

      if (move_uploaded_file($userPhoto['tmp_name'], $uploadfile))
      {        
         return $name;
      }
      else
      {
         return false;
      }
      return true;
   }
   function checkSkills($skillCoding, $skillPhotoshop, $skillVideoediting)
   {
      $user = R::findOne('users', 'id = ?', array($_SESSION['user']->id));

      if((($skillCoding && $user->skillCoding) == $skillCoding) && (($skillPhotoshop && $user->skillPhotoshop) == $skillPhotoshop) && (($skillVideoediting && $user->skillVideoediting) == $skillVideoediting))
      {
         return true;
      }
      return false;     
   }
?>
