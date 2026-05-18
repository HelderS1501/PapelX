var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Start Project
app.Run();

// Code Model
// app.MapGet("/", () => "Hello World!");