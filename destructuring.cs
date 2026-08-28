using System;
using System.IO;

var (a, b, c) = Entity.GetData();
Console.WriteLine($"{a}, {b}, {c}");

(int aa, float bb, string cc) = Entity.GetData();
Console.WriteLine($"{aa}, {bb}, {cc}");
public static class Entity
{
    public static (int, float, string) GetData()
    {
        return (10, 10.0f, "10");
    }
}