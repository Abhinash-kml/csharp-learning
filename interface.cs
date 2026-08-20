using System.IO;

IDescribable ent = new Entity();
ent.Describe();
// IDescribable nent = new NotEntity();
// nent.Describe();
var expent = new ExplicitEntity();
IDescribable des = expent;
ISay say = expent;
des.Describe();
say.Describe();

public class Entity : IDescribable
{
    public string Name => "Name";
    public void Describe()
    {
        Console.WriteLine("Interface implemented");
    }
}

public class ExplicitEntity : IDescribable, ISay
{
    public string Name => "meow";

    void IDescribable.Describe()
    {
        Console.WriteLine("Explicit IDescribable.Describe");
    }

    void ISay.Describe()
    {
        Console.WriteLine("Explicit ISay.Describe");
    }
}

public class NotEntity {}

public interface IDescribable
{
    public string Name { get; }
    public void Describe();
}

public interface ISay
{
    public void Describe();
}

public interface InheritedIFace : IDescribable, ISay{}