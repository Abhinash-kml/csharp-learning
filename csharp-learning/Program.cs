using System.IO.Enumeration;

namespace csharp_learning;

public class Concurrency
{
    private readonly string _Name;
    public string Name => _Name;

    public async Task TaskUsage()
    {
        Action action = () => Console.WriteLine("Async Task usage");
        await Task.Run(action);
    }

    public async Task<int> TaskTUsage()
    {
        Action<int> action = (int a) => Console.WriteLine($"Async Task<T> usage. Value {a}");
        await Task.Run((() => action(10)));
        return 10;
    }

    public async Task TimerUsage()
    {
        
    }

    public async Task PeriodicTimerUsage()
    {
        PeriodicTimer pt = new PeriodicTimer(TimeSpan.FromSeconds(1));
        while (await pt.WaitForNextTickAsync())
            Console.WriteLine("Periodic Timer Tick");
    }
}

static class Program
{
    static void Main(string[] args)
    {
        
    }
}