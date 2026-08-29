using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

Entity e = new();
// await e.Process();
await e.ProcessAll();

Task<int> a = e.ProcessInt();
await a.ContinueWith(intTask =>
{
    int val = intTask.Result;
    Console.WriteLine($"Int Task result = {val}");
    return e.ProcessString();
})
.Unwrap()
.ContinueWith(strTask =>
{
    string val = strTask.Result;
    Console.WriteLine($"String task value = {val}");
});

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

    public async Task<int> ProcessTaskWithvalue()
    {
        return 10;
    }

    public async Task ProcessAll()
    {
        Stopwatch s = new Stopwatch();
        s.Start();

        Task<int> intTask = ProcessInt();
        Task<string> stringTask = ProcessString();
        await Task.WhenAll(intTask, stringTask);
        Console.WriteLine("Processed all tasks");
        // Console.WriteLine(result.ToString());

        s.Stop();
        TimeSpan elapsed = s.Elapsed;
        Console.WriteLine($"Elapsed seconds = {elapsed.TotalSeconds}");
    }
}