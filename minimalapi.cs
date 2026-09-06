#:sdk Microsoft.NET.Sdk.Web
// #:property PublishSingleFile true
// #:property SelfContained true
// #:property ReadyToRun true

using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    EnvironmentName = Environments.Development
});
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolver = MyJsonSerializerContext.Default;
});
builder.Services.AddProblemDetails();

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
publicRoutes.MapGet("/problem", () => TypedResults.Problem(
    detail: "www.xyx.com",
    instance: "/////",
    statusCode: 100,
    title: "meow meow",
    type: "meow"
));
publicRoutes.MapGet("/context", async (HttpContext context) =>
{
    Console.WriteLine($" --- Request ---");
    Console.WriteLine($"Host: {context.Request.Host.Host}");
    Console.WriteLine($"Protocol: {context.Request.Protocol}");
    Console.WriteLine($"Content-Length: {context.Request.ContentLength ?? 0}");
    Console.WriteLine($"Content-Type: {context.Request.ContentType ?? "No content"}");
    Console.WriteLine($"Scheme: {context.Request.Scheme}");
    Console.WriteLine($"Protocol: {context.Request.Protocol}");
    Console.WriteLine($"Path: {context.Request.Path.Value}");
    Console.WriteLine($"Query: {context.Request.QueryString.Value}");

    var queries = context.Request.Query;
    foreach (var (query, value) in queries)
        Console.WriteLine($"Query: {query} - Value: {value}");

    var headers = context.Request.Headers;
    Console.WriteLine("Headers:");
    foreach (var (header, value) in headers)
        Console.WriteLine($"Header: {header} - Value: {value}");

    var reader = new StreamReader(context.Request.Body);
    string body = await reader.ReadToEndAsync();
    Console.WriteLine($"Body:\n{body}");
});
publicRoutes.MapMethods("/query", ["QUERY"], (HttpContext context) =>
{
    return Results.Ok("Used QUERY Method");
});
publicRoutes.MapGet("/implicit/{id:int}", (int id, string type) =>
{
    return Results.Ok($"Path: {id} - Query: {type}");
});
publicRoutes.MapGet("/explicit/{id:int}", ([FromRoute] int id, [FromQuery] string type) =>
{
    return Results.Ok(new Data
    {
        Id = id,
        Type = type
    });
});

// Private routes
privateRoutes.MapGet("/hello", () => "Hello from private route");
privateRoutes.MapGet("/{id:int}", (int id) =>
{
    return $"Int id is {id}";
});


app.Run("http://localhost:8000");

public record struct EntityDto(Guid Id, string Name, int Health);
public record struct Data(int Id, string Type);


[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(float))]
[JsonSerializable(typeof(EntityDto))]
[JsonSerializable(typeof(Data))]
public partial class MyJsonSerializerContext : JsonSerializerContext{}