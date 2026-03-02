var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "Multi Branch Pipeline Demo - Main Branch");
app.MapGet("/version", () => "API Version 1.0");

app.Run();