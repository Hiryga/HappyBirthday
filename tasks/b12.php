<?php
$a = isset($_POST['a']) ? floatval($_POST['a']) : 0;
$b = isset($_POST['b']) ? floatval($_POST['b']) : 0;
$c = isset($_POST['c']) ? floatval($_POST['c']) : 0;
$sum = $a + $b + $c;
?>
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>Результат</title>
</head>
<body>
<h2>Результат</h2>
<p>Сумма чисел <?php echo "$a, $b, $c"; ?> равна <?php echo $sum; ?>.</p>
<p><a href="b12.html">Назад</a></p>
</body>
</html>