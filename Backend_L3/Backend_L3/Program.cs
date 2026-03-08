var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/html", () =>
{
    string html = "<h1>Hello World!</h1><p>It is laba 3!</p>";
    return Results.Content(html, "text/html");
});

app.MapGet("/text", () =>
{
    return Results.Text("Это обычный текстовый ответ");
});

app.MapGet("/json", () =>
{
    var user = new
    {
        Name = "Adelina",
        Age = 21
    };

    return Results.Json(user);
});

app.MapGet("/xml", () =>
{
    string xml = "<user><name>Adelina</name><age>21</age></user>";
    return Results.Content(xml, "application/xml");
});

app.MapGet("/csv", () =>
{
    string csv = "Name,Age\nAdelina,21\nAnna,25";
    return Results.Content(csv, "text/csv");
});

app.MapGet("/binary", () =>
{
    byte[] data = { 1, 2, 3, 4, 5 };
    return Results.File(data, "application/octet-stream", "data.bin");
});

app.MapGet("/image", () =>
{
    var path = Path.Combine(Directory.GetCurrentDirectory(), "image.png");
    return Results.File(path, "image/png");
});

app.MapGet("/pdf", () =>
{
    var path = Path.Combine(Directory.GetCurrentDirectory(), "file.pdf");
    return Results.File(path, "application/pdf");
});

app.MapGet("/redirect", () =>
    {
        return Results.Redirect("/html");
    });

app.Run();