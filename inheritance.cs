using System.IO;

Student s = new("Neo", 15);
Console.WriteLine($"Student = Id: {s.Id} - Name: {s.Name}");
public class Human
{
    public Guid Id { get; } = Guid.CreateVersion7();
    public string Name { get; set; }

    public Human() {}
    public Human(string name)
    {
        Name = name;
    }
}

public class Student : Human
{
    public int Standard { get; }
    public Student(string name, int standard) : base(name)
    {
        Standard = standard;
    }
}