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