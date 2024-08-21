<html>
<body>

<?php
	$date = date_create($_POST['date']);
	$day = abs($_POST['nday']);
	$month = abs($_POST['nmonth']);
	$year = abs($_POST['nyear']);
	$newdate = date_create('$year-$month-$day');
	$interval = new DateInterval(sprintf('P%dY%dM%dD', $year, $month, $year));
	
	date_add($date, $interval);
	echo date_format($date, 'Y.m.d');
?>

</body>
</html>


