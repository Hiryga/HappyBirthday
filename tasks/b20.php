<?php
$n = isset($_POST['n']) ? intval($_POST['n']) : 0;
$even = ($n % 2 == 0);
?>
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>Результат</title>
</head>
<body>
<h2>Результат запроса</h2>
<p>Число <?php echo $n; ?> является <?php echo $even ? 'чётным' : 'нечётным'; ?>.</p>
<p><a href="b20.html">Назад</a></p>
</body>
</html>