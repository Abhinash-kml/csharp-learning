using System.IO;

Wrapper<int> w = new Wrapper<int>(109);
w.Describe();
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