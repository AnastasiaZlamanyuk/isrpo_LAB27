var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Привет от ИСП-231! Авторы: Лиза и Настя");

app.Run();
