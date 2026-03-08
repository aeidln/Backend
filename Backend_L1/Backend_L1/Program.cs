using Backend_L1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// главная страница
app.MapGet("/", () => Results.Text(One.MainPage(), "text/html; charset=utf-8"));

// о нас
app.MapGet("/about", () => Results.Text(One.AboutPage(), "text/html; charset=utf-8"));

// контакты
app.MapGet("/contact", () => Results.Text(One.ContactPage(), "text/html; charset=utf-8"));

// простой текст
app.MapGet("/hello", () => "Привет!");

// JSON ответ
app.MapGet("/api/user", () =>
{
    return Results.Ok(new
    {
        name = "Davletova Adelina",
        role = "Student",
        status = "Online"
    });
});

// текущее время
app.MapGet("/api/time", () => Results.Ok(DateTime.Now));

app.Run();
