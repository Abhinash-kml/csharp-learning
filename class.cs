using System.Diagnostics.Contracts;
using System.IO;

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
                throw NullReferenceException;

            _age = value;
        }
    }

    
}

// Main section
Console.WriteLine("hello World");