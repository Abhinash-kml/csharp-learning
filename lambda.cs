using System.IO;

callback a = (int val) => Console.WriteLine($"Value = {val}");
a(10);
callback b = (val) => Console.WriteLine($"Value = {val}");
b(10);

CallbackWithReturn aa = (val) =>  { return val; };
Console.WriteLine($"CallbackWithReturn = {aa(11)}");
delegate void callback(int value);
delegate int CallbackWithReturn(int value);