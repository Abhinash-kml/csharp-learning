using System.Diagnostics;
using System.IO;
using System.Timers;

Stopwatch s = new Stopwatch();
s.Start();
Thread.Sleep(2000);
s.Stop();
Console.WriteLine($"Elapsed time = {s.Elapsed}");