var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//Minha local host http://localhost:5131

app.MapGet("/", () => "Hello World,let's get it");

app.Run();
