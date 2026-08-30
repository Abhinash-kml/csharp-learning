using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;

Entity e = new Entity
{
    Name = "Entity 1",
    Age = 15
};
Console.WriteLine(e.ID);

EntityWrapper w = new EntityWrapper
{
    Id = Guid.CreateVersion7(),
    Entity = new Entity
    {
        Name = "Wrapped Entity",
        Age = 16
    }
};

Console.WriteLine(w.ToString());

List<int> l1 = new List<int>{ 1, 2, 3, 4, 5};
List<int> l2 = new List<int>{ 6, 7, 8, 9, 10};
Console.WriteLine(string.Join(",", l1));
Console.WriteLine(string.Join(",", l2));

List<int> combined = [..l1, ..l2];
Console.WriteLine(string.Join(",", combined));

List<int> l3 = [1, 2, 3, 4, 5];
Console.WriteLine(string.Join(",", l3));

public class EntityWrapper
{
    public Guid Id { get; set; }
    public Entity Entity { get; set; }
}

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