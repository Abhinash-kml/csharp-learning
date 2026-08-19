using System.IO;

IDescribable ent = new Entity();
ent.Describe();
// IDescribable nent = new NotEntity();
// nent.Describe();

public class Entity : IDescribable
{
    public void Describe()
    {
        Console.WriteLine("Interface implemented");
    }
}

public class NotEntity {}

public interface IDescribable
{
    public void Describe();
}