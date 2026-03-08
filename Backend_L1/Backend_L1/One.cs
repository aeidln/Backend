namespace Backend_L1;

public static class One
{
    public static string MainPage() => """
    <html>
    <head><title>Главная</title></head>
    <body>
        <h1>Добро пожаловать!</h1>
        <p>Это главная страница.</p>
        <a href="/about">О нас</a><br>
        <a href="/contact">Контакты</a><br>
        <a href="/api/user">API пример</a>
    </body>
    </html>
    """;

    public static string AboutPage() => """
    <html>
    <body>
        <h1>О нас</h1>
        <p>Практическая работа 1. Создание приложения на основе класса WebApplication на основе ASP.NET Core</p>
        <a href="/">Назад</a>
    </body>
    </html>
    """;

    public static string ContactPage() => """
    <html>
    <body>
        <h1>Контакты</h1>
        <p>Давлетова Аделина</p>
        <p>Группа: 241-331</p>
        <p>Email: aeidln@yandex.ru</p>
        <a href="/">Назад</a>
    </body>
    </html>
    """;
}
