<?php
   require "libs/functions.php";
   require "libs/rb.php";
   //error_reporting(0);
   $host = 'localhost';
   $dbname = 'mpei';
   $login = 'root';
   $password = '';

   R::setup("mysql:host=$host;dbname=$dbname", $login, $password);
   
   session_start();
   $_SESSION["userID"] = "php_user";
   $_SESSION["password"] = "tutorials";
   //array($_SESSION['user']->id)
   $_SESSION['user'] = array();

    //$query = R::findAll( 'users' );
    // а можно и так  $query = R::getAll( 'SELECT * FROM jobs' ); 
    //echo $query->firstname;

   //$rows_job =  R::findAll( 'users' );
   //foreach ($rows_job as $row){
   //echo 'ID: ' . $row['id'] . '<br>';
   //echo 'ID: ' . $row['firstname'] . '<br>';
   //}


   $test = R::load('users', 1);
   echo $test->firstname;

   print_r($_SESSION);
?> 