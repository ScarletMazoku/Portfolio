<?php
	echo "Имя: " . $_POST['FirstName'] . "<br>";
	echo "Дата обращения: " . $_POST['RequestDate'] . "<br>";
	echo "Дата решения проблемы: " . $_POST['SolutionDate'] . "<br>";
	echo "Сотрудник: " . $_POST['select'] . "<br>";
	echo "Оценка: " . $_POST['Rate'] . "<br>";
	if (!empty($_POST['d']))
	{
		echo "Личное обращение   <br>";
	}
	if (!empty($_POST['e']))
	{
		echo "Онлайн-обращение   <br>";
	}
	echo "Адрес: " . $_POST['Address'] . "<br>";
	echo "Проблема: " . $_POST['About'] . "<br>";
	if (!empty($_POST['a']))
	{
		echo "Отзывчивость   <br>";
	}
	if (!empty($_POST['b']))
	{
		echo "Готовность решения проблемы   <br>";
	}
	if (!empty($_POST['c']))
	{
		echo "Компетентность   <br>";
	}
	if (!empty($_POST['f']))
	{
		echo "Вежливость   <br>";
	}
	echo "Моменты: " . $_POST['Moments'] . "<br>";
	if (!empty($_POST['g']))
	{
		echo "Дальнейшее общение: Да  <br>";
	}
	if (!empty($_POST['h']))
	{
		echo "Дальнейшее общение: Нет  <br>";
	}
	if (!empty($_POST['i']))
	{
		echo "Дальнейшее общение: Возможно  <br>";
	}
?>