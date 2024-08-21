<?php
   require "db.php";
   unset($_SESSION['user']);
   header('location:index.php');
?>
