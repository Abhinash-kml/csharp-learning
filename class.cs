using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.IO;

// Main section
Console.WriteLine("hello World");
Entity ent = new Entity();
ent.Age = 99;
ent.Name = "neo";
Console.WriteLine($"Entity info - \nId = {ent.Id}\nName = {ent.Name}\nAge = {ent.Age}");

public class Entity
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    private string? _name;
    public string? Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            if ((value < 10) || (value > 100))
                throw new ArgumentException("The provided argument cannot pass validation");

            _age = value;
        }
    } 
}