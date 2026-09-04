#:sdk Microsoft.NET.Sdk.Web
// #:property PublishSingleFile true
// #:property SelfContained true
// #:property ReadyToRun true

using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    EnvironmentName = Environments.Development
});
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolver = MyJsonSerializerContext.Default;
});

var app = builder.Build();
app.UseDeveloperExceptionPage();

Console.WriteLine($"App is running in {app.Environment.EnvironmentName} enviroment");

// Build route groups
RouteGroupBuilder publicRoutes = app.MapGroup("api/public");
RouteGroupBuilder privateRoutes = app.MapGroup("api/private");

// Public routes
publicRoutes.MapGet("/hello", () => "Hello from public route");
publicRoutes.MapGet("/{id:int}", (int id) =>
{
    return $"Int id is {id}";
});
publicRoutes.MapGet("/typed", () => TypedResults.Ok());
publicRoutes.MapGet("/entity", () => TypedResults.Ok<EntityDto>(new EntityDto
{
    Id = Guid.CreateVersion7(),
    Name = "Neo",
    Health = 100
}));
publicRoutes.MapGet("/exception", () => {
    throw new ArgumentException("Invalid argument");
});

// Private routes
privateRoutes.MapGet("/hello", () => "Hello from private route");
privateRoutes.MapGet("/{id:int}", (int id) =>
{
    return $"Int id is {id}";
});


app.Run("http://localhost:8000");

public record struct EntityDto(Guid Id, string Name, int Health);

[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(float))]
[JsonSerializable(typeof(EntityDto))]
public partial class MyJsonSerializerContext : JsonSerializerContext{}