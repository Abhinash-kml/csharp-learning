#:sdk Microsoft.NET.Sdk.Web
// #:property PublishSingleFile true
// #:property SelfContained true
// #:property ReadyToRun true

using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolver = MyJsonSerializerContext.Default;
});
var app = builder.Build();

app.MapGet("/api/hello", () => "Hello from single file minimal api");
app.MapGet("/api/{id}", (int id) =>
{
    return id;
});

app.Run("http://localhost:8000");

[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(float))]
public partial class MyJsonSerializerContext : JsonSerializerContext{}