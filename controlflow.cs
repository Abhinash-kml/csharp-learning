using System.IO;

int value = 20;
int calculated = value switch
{
    >= 30 => 300,
    >= 20 => 200,
    _ => 100
};
Console.WriteLine(calculated);