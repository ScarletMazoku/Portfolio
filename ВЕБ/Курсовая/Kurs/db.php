<?php
   require "libs/functions.php";
   require "libs/rb.php";
   error_reporting(0);
   $host = 'localhost';
   $dbname = 'mpei';
   $login = 'root';
   $password = '';

   R::setup("mysql:host=$host;dbname=$dbname", $login, $password);
   
   session_start();
   $test = R::load('users', 1);
   $_SESSION['user']; 
   //$_SESSION['user'] = $test;
   //$_SESSION['user'] =  R::getRow( 'SELECT * FROM users WHERE title LIKE ? LIMIT 1', [ '1' ]);
?> 
