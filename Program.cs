var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "Multi Branch Pipeline Demo - Main Branch");
app.MapGet("/time", () => DateTime.Now.ToString());

app.Run();