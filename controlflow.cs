using System.IO;

int value = 20;
int calculated = value switch
{
    >= 30 => 300,
    >= 20 => 200,
    _ => 100
};
Console.WriteLine(calculated);

int? meow = null;

if (meow is null)
    Console.WriteLine("Null");

meow = 10;

if (meow is not null)
    Console.WriteLine("Not null");

if (meow is int val)
    Console.WriteLine($"Value = {val}");

State s = State.On;
s switch
{
    State.On => Console.WriteLine("On"),
    State.Off => Console.WriteLine("Off"),
    State.Deafult => Console.WriteLine("Deafault"),
    _ => Console.WriteLine("None")
};

string ss = "neo";
switch (ss)
{
    case "neo":
    Console.WriteLine("neo");
    break;

    case "peo":
    Console.WriteLine("peo");
    break;
}
enum State
{
    Deafult,
    On,
    Off
}