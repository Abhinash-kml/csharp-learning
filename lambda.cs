using System.IO;

callback a = (int val) => Console.WriteLine($"Value = {val}");
a(10);
callback b = (val) => Console.WriteLine($"Value = {val}");
b(10);

CallbackWithReturn aa = (val) =>  { return val; };
Console.WriteLine($"CallbackWithReturn = {aa(11)}");

// Action is a delegate with no return type, basically void return type
Action<int> aaa = (int value) => Console.WriteLine(value);
aaa.Invoke(100);
aaa(1000);

// Func is a delegate with a return type other than void, the last type parameter is the return type
Func<int, int> bbb = (int value) => value;
var value = bbb.Invoke(200);
Console.WriteLine(value);
value = bbb(2000);
Console.WriteLine(value);

delegate void callback(int value);
delegate int CallbackWithReturn(int value);