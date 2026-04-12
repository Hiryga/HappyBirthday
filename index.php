<?php
// Настройка: какие файлы относятся к каждому билету
$tickets = [
    1 => [
        'title' => 'Подписка (JS)',
        'files' => ['tasks/b1.html']
    ],
    2 => [
        'title' => 'Площадь круга/квадрата (JS)',
        'files' => ['tasks/b2.html']
    ],
    3 => [
        'title' => 'Проверка ответа (JS)',
        'files' => ['tasks/b3.html']
    ],
    4 => [
        'title' => 'Изменение размеров изображения (JS)',
        'files' => ['tasks/b4.html']
    ],
    5 => [
        'title' => 'Графическое меню (JS)',
        'files' => ['tasks/b5.html']
    ],
    6 => [
        'title' => 'Первые строки и первая буква (CSS)',
        'files' => ['tasks/b6.html', 'styles/styles6.css']
    ],
    7 => [
        'title' => 'Квадрат числа (JS)',
        'files' => ['tasks/b7.html']
    ],
    8 => [
        'title' => 'Внешний стиль (фон, заголовок, первый абзац)',
        'files' => ['tasks/b8.html', 'styles/styles8.css']
    ],
    9 => [
        'title' => '1-й абзац с большой буквой, 2-й курсив',
        'files' => ['tasks/b9.html', 'styles/styles9.css']
    ],
    10 => [
        'title' => 'Степень числа (PHP)',
        'files' => ['tasks/b10.html', 'tasks/b10.php']
    ],
    11 => [
        'title' => 'Привет друг мой (PHP)',
        'files' => ['tasks/b11.html', 'tasks/b11.php']
    ],
    12 => [
        'title' => 'Три числа, сумма (PHP)',
        'files' => ['tasks/b12.html', 'tasks/b12.php']
    ],
    13 => [
        'title' => 'Любители мороженого и шоколада (JS)',
        'files' => ['tasks/b13.html']
    ],
    14 => [
        'title' => 'Подписка (JS, билет 14)',
        'files' => ['tasks/b14.html']
    ],
    15 => [
        'title' => 'Площадь круга/квадрата (JS, билет 15)',
        'files' => ['tasks/b15.html']
    ],
    16 => [
        'title' => 'Графическое меню (JS, билет 16)',
        'files' => ['tasks/b16.html']
    ],
    17 => [
        'title' => 'Оформление абзацев (CSS, билет 17)',
        'files' => ['tasks/b17.html', 'styles/styles17.css']
    ],
    18 => [
        'title' => 'Площадь круга/квадрата (JS, билет 18)',
        'files' => ['tasks/b18.html']
    ],
    19 => [
        'title' => 'Элементы ввода: text, select, radio (JS)',
        'files' => ['tasks/b19.html']
    ],
    20 => [
        'title' => 'Проверка числа (PHP, билет 20)',
        'files' => ['tasks/b20.html', 'tasks/b20.php']
    ],
    21 => [
        'title' => 'Три числа, среднее (PHP, билет 21)',
        'files' => ['tasks/b21.html', 'tasks/b21.php']
    ],
    22 => [
        'title' => 'Графическое меню (JS, билет 22)',
        'files' => ['tasks/b22.html']
    ],
    23 => [
        'title' => 'Первые строки + первая буква (CSS, билет 23)',
        'files' => ['tasks/b23.html', 'styles/styles23.css']
    ],
];

$selected = isset($_GET['ticket']) ? intval($_GET['ticket']) : null;
?>
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>Экзаменационные билеты МДК 01.01</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 20px; display: flex; gap: 20px; }
        .sidebar { width: 260px; border-right: 1px solid #ccc; padding-right: 15px; }
        .content { flex: 1; }
        h1 { font-size: 22px; margin-bottom: 10px; }
        ul { list-style: none; padding: 0; }
        li { margin-bottom: 5px; }
        a { text-decoration: none; color: #0066cc; }
        a:hover { text-decoration: underline; }
        .ticket-title { font-weight: bold; margin-bottom: 10px; }
        .code-block { margin-top: 10px; }
        pre {
            background: #f5f5f5;
            border: 1px solid #ddd;
            padding: 10px;
            overflow-x: auto;
            font-size: 13px;
        }
        iframe {
            width: 100%;
            height: 400px;
            border: 1px solid #ccc;
            background: white;
        }
        .file-name {
            font-weight: bold;
            margin-top: 5px;
        }
        .note { font-size: 12px; color: #555; margin-top: 5px; }
    </style>
</head>
<body>

<div class="sidebar">
    <h1>Билеты 1–23</h1>
    <ul>
        <?php foreach ($tickets as $num => $info): ?>
            <li>
                <a href="?ticket=<?php echo $num; ?>">
                    Билет <?php echo $num; ?> — <?php echo htmlspecialchars($info['title']); ?>
                </a>
            </li>
        <?php endforeach; ?>
    </ul>
</div>

<div class="content">
    <?php if ($selected && isset($tickets[$selected])): ?>
        <?php $info = $tickets[$selected]; ?>
        <div class="ticket-title">
            Билет <?php echo $selected; ?> — <?php echo htmlspecialchars($info['title']); ?>
        </div>

        <?php
        // Первый html-файл билета для предпросмотра
        $previewFile = null;
        foreach ($info['files'] as $f) {
            if (str_ends_with($f, '.html')) {
                $previewFile = $f;
                break;
            }
        }
        ?>

        <?php if ($previewFile && file_exists($previewFile)): ?>
            <h3>Предпросмотр задания</h3>
            <iframe src="<?php echo htmlspecialchars($previewFile); ?>"></iframe>
            <div class="note">Если не отображается, проверь путь к файлам билета.</div>
        <?php endif; ?>

        <h3>Исходный код</h3>
        <?php foreach ($info['files'] as $file): ?>
            <div class="code-block">
                <div class="file-name"><?php echo $file; ?></div>
                <?php if (file_exists($file)): ?>
                    <pre><?php echo htmlspecialchars(file_get_contents($file)); ?></pre>
                <?php else: ?>
                    <pre>// Файл не найден: <?php echo $file; ?></pre>
                <?php endif; ?>
            </div>
        <?php endforeach; ?>

    <?php else: ?>
        <h2>Выберите билет слева</h2>
        <p>Нажмите на номер билета, чтобы увидеть работающий пример и исходный код.</p>
    <?php endif; ?>
</div>

</body>
</html>