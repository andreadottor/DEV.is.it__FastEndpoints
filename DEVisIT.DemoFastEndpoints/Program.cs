using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapFastEndpoints();
app.UseSwaggerGen();

app.Run();
