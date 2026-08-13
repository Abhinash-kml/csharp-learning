using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.IO;
using System.Security.Cryptography;

// Main section
Console.WriteLine("hello World");
Entity ent = new Entity();
ent.Age = 99;
ent.Name = "neo";
ent.PrintDetails();

Entity ent2 = new Entity("neo2", 55);
ent2.PrintDetails();

Human h = new Human("Human", 32);
h.Hobbies?.Add("Singing");
h.Hobbies?.AddRange(new List<string>{"Dancing", "Swimming"});
int? len = h.Hobbies?.Count;
Console.WriteLine("$Human has {len} hobbies");
foreach (var hobby in h.Hobbies)
    Console.WriteLine(hobby);
public class Entity
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    private string _name;
    public string Name
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

    public Entity() {}
    public Entity(string name, int age)
    {
        _name = name;
        _age = age;

        Console.WriteLine("Constructed");
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Entity info - \nId = {Id}\nName = {Name}\nAge = {Age}");
    } 
}

public class Human : Entity
{
    public readonly string tag = "Human";
    public int Health { get; } = 10;
    public Human(string name, int age)
        : base(name, age)
        {}

    public Human() {}

    public List<string>? Hobbies { get; }
}