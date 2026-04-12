<?php
$name = isset($_POST['name']) ? trim($_POST['name']) : '';
if ($name === '') {
    $name = 'друг мой';
}
?>
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>Приветствие</title>
</head>
<body>
<h2>Результат</h2>
<p>Привет, друг мой <?php echo htmlspecialchars($name); ?>!</p>
<p><a href="b11.html">Назад</a></p>
</body>
</html>