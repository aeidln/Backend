using System;

var builder = WebApplication.CreateBuilder(args);

// подключаем Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// включаем Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/hello", (string name, int age) =>
{
    return $"Привет, {name}! Тебе {age} лет.";
});

app.MapPost("/person", (Person person) =>
{
    return $"Получен человек: {person.Name}, возраст {person.Age}";
});

app.MapPost("/order", (int id, Person person) =>
{
    return $"Заказ №{id} оформлен на {person.Name}";
});

app.MapPut("/person", (Person person) =>
{
    return $"Данные обновлены: {person.Name}, {person.Age}";
});

app.MapPatch("/person/{name}", (string name, int age) =>
{
    return $"Возраст пользователя {name} обновлён на {age}";
});
app.Run();