using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

Entity e = new Entity{ Id = Guid.CreateVersion7(), Name = "neo", Type = "human", Tag = "ABC" };

string json = JsonSerializer.Serialize(e, typeof(Entity), EntityContext.Default);
Console.WriteLine(json);

Entity f = JsonSerializer.Deserialize<Entity>(json, EntityContext.Default.Entity);
Console.WriteLine(f.Id);

[JsonSourceGenerationOptions(IncludeFields = true)]
[JsonSerializable(typeof(Entity))]
public partial class EntityContext : JsonSerializerContext {}
public struct Entity
{
    public Guid Id = Guid.CreateVersion7();
    public string? Name { get; set; }
    public string? Type { get; set; }

    public string? Tag;

    public Entity(string name, string type)
    {
        Name = name;
        Type = type;
    }
}