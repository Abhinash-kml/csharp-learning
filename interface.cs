using System.IO;

IDescribable ent = new Entity();
ent.Describe();
// IDescribable nent = new NotEntity();
// nent.Describe();

public class Entity : IDescribable
{
    public string Name => "Name";
    public void Describe()
    {
        Console.WriteLine("Interface implemented");
    }
}

public class NotEntity {}

public interface IDescribable
{
    public string Name { get; }
    public void Describe();
}