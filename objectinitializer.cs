using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

Entity e = new Entity
{
    Name = "Entity 1",
    Age = 15
};
Console.WriteLine(e.ID);

public class Entity
{
    public Guid ID { get; init; } = Guid.CreateVersion7();
    public string Name { get; set; }
    public int Age
    {
        get;
        set
        {
            if ((value < 10) || (value > 20))
                throw new ArgumentOutOfRangeException("Age", "Range = 10 - 20");

            field = value;
        }
    }
}