

using Marten;
using Todos.Api.Todos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthorization();

var connectionString = builder.Configuration.GetConnectionString("todos") ??
    throw new Exception("CAn't start the api without a connection string");
builder.Services.AddMarten(builder =>
{
    builder.Connection(connectionString);
});


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();
app.MapTodos();

app.Run();


public partial class Program { }