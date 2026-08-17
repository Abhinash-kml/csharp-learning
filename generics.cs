using System.IO;

Wrapper<int> w = new Wrapper<int>(109);
w.Describe();
var ww = new Wrapper<float>(100.0f);
ww.Describe();
GenericStruct<int> gs = new GenericStruct<int>();
gs.Data = 100;
gs.Describe();
public class Wrapper<T>
{
    public T Data { get; set; }

    public Wrapper(T data)
    {
        Data = data;
    }

    public void Describe()
    {
        Console.WriteLine($"The internal data type is {typeof(T)}");
    }
}

public struct GenericStruct<T>
{
    public T Data { get; set; }
    public void Describe()
    {
        Console.WriteLine($"The internal data type is {typeof(T)}");
    }
}