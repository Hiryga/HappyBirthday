<?php
// power.php
$base = isset($_POST['base']) ? floatval($_POST['base']) : 0;
$exp = isset($_POST['exp']) ? intval($_POST['exp']) : 0;
$result = pow($base, $exp);
?>
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>Результат</title>
</head>
<body>
<h2>Результат вычисления степени</h2>
<p>
    Число <?php echo $base; ?> в степени <?php echo $exp; ?> равно <?php echo $result; ?>.
</p>
<p><a href="b10.html">Назад</a></p>
</body>
</html>