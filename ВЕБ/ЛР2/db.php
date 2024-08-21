<?php
	define('DB_HOST', 'localhost');
	define('DB_USER', 'root');
	define('DB_PASSWORD', '1234');
	define('DB_NAME', 'WEB_PR2');

	$mysql = @new mysqli(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);
	if ($mysql->connect_errno) exit('Error to connect');
	$mysql->set_charset('utf8');
	$mysql->close();
?>