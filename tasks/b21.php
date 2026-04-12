<?php
$a = isset($_POST['a']) ? floatval($_POST['a']) : 0;
$b = isset($_POST['b']) ? floatval($_POST['b']) : 0;
$c = isset($_POST['c']) ? floatval($_POST['c']) : 0;
$avg = ($a + $b + $c) / 3;
?>
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>Результат</title>
</head>
<body>
<h2>Результат</h2>
<p>Среднее арифметическое чисел <?php echo "$a, $b, $c"; ?> равно <?php echo $avg; ?>.</p>
<p><a href="b21.html">Назад</a></p>
</body>
</html>