var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Привет от ИСП-231! Авторы: Лиза и Настя");
// app.MapGet("/", () => "Добро пожаловать на сервер!");
// app.MapGet("/about", () => "Это мой первый ASP.NET Core сервер");
// app.MapGet("/time", () => $"Время на сервере: {DateTime.Now}");
// app.MapGet("/hello/{name}", (string name) => $"Привет, {name}!");
// app.MapGet("/sum/{a}/{b}", (int a, int b) => $"Сумма: {a + b}");
// app.MapGet("/student", () => new
// {
//     Name = "Лиза Настьевна",
//     Group = "ИСП-231",
//     Year = 3,
//     IsActive = true
// });
// app.MapGet("/subjects", () => new[]
// {
//     "РМП",
//     "РПМ",
//     "ИСРПО",
//     "СП",
// });
app.MapGet("/product/{id}", (int id) => new Product(
    Id: id,
    Name: $"Товар #{id}",
    Price: id * 99.99m,
    InStock: id % 2 == 0
));
app.Run();
record Product(int Id, string Name, decimal Price, bool InStock);
