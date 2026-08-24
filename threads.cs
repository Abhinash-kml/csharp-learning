using System.IO;

Action<int> action = (int val) =>
{
    Thread.Sleep(5000);
    Console.WriteLine("After 5 sec from thread 1");
    Console.WriteLine(val);
};
ThreadStart thstart = new ThreadStart(() => action(10));
Thread th1 = new Thread(thstart);

// th1.Start();
// th1.Join();

Thread th2 = new Thread(() => Console.WriteLine("thread 2"));
th2.Start();
th2.Join();

ThreadPool.QueueUserWorkItem((object? o) => Console.WriteLine("meow"));

Action<int> ac = (int val) => Console.WriteLine($"Val = {val}");
ThreadPool.QueueUserWorkItem<int>(ac, 100, true);

Action<int, float> acf = (int a, float b) => Console.WriteLine($"Int = {a} - Float = {b}");
ThreadPool.QueueUserWorkItem<int, float>(
                                        state => state.action(state.i, state.f), 
                                        (action = acf, i: 100, f: 200), 
                                        false);
Thread.Sleep(5000);

Console.WriteLine("End main thread");