using System.Diagnostics;
using System.IO;

Entity e = new();
await e.Process();

public class Entity
{
    public async Task Process()
    {
        Stopwatch s = new Stopwatch();
        s.Start();

        int intVal = await ProcessInt();
        Console.WriteLine($"Processed int = {intVal}");
        string stringVal = await ProcessString();
        Console.WriteLine($"Processed string = {stringVal}");

        s.Stop();
        TimeSpan elapsed = TimeSpan.FromMilliseconds(s.ElapsedMilliseconds);
        Console.WriteLine($"Total time elapsed = {elapsed.TotalSeconds}");
    }

    public async Task<string> ProcessString()
    {
        Thread.Sleep(3000);
        return "Meow Meow";
    }

    public async Task<int> ProcessInt()
    {
        Thread.Sleep(3000);
        return 10;
    }
}