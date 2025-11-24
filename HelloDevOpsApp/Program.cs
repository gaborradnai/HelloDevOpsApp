var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello DevOps!");
app.MapGet("/feature", () => "Hello DevOps from feature branch!");

app.Run();
