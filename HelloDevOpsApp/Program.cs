var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello DevOps!");
app.MapGet("/feature", () => "Hello DevOps_V2 from feature branch!");

app.Run();
