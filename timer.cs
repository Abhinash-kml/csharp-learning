using System.Diagnostics;
using System.IO;
using System.Timers;

static void CallbackFunction(Object source, ElapsedEventArgs e)
{
    Console.WriteLine($"System.Timers.Timer Tick time = {e.SignalTime}");
}

Stopwatch s = new Stopwatch();
s.Start();
Thread.Sleep(2000);
s.Stop();
Console.WriteLine($"Elapsed time = {s.Elapsed}");

var t = new System.Timers.Timer(2000);
t.Elapsed += CallbackFunction;
t.Enabled = true;
t.AutoReset = true;
t.Start();

int count = 0;
var pt = new PeriodicTimer(TimeSpan.FromSeconds(2));
while (await pt.WaitForNextTickAsync())
{
    count++;
    Console.WriteLine($"PeridicTimer Tick count = {count}");
}