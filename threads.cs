using System.IO;

Action<int> action = (int val) =>
{
    Thread.Sleep(5000);
    Console.WriteLine("After 5 sec from thread 1");
    Console.WriteLine(val);
};
ThreadStart thstart = new ThreadStart(() => action(10));
Thread th1 = new Thread(thstart);

th1.Start();
th1.Join();

Console.WriteLine("End main thread");