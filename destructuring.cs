using System;
using System.IO;

Entity Entity = new();

var (a, b, c) = Entity.GetData(10, 10.0f, "10");
Console.WriteLine($"{a}, {b}, {c}");

(int aa, float bb, string cc) = Entity.GetData(10, 10.0f, "10");
Console.WriteLine($"{aa}, {bb}, {cc}");

(int aaa, var bbb, _) = Entity.GetData(20, 20.0f, "20");
Console.WriteLine($"{aaa}, {bbb}");

var (aaaa, bbbb, cccc) = Entity;
Console.WriteLine($"{aaaa}, {bbbb}, {cccc}");
public class Entity
{
    private int _a = 100;
    private float _b = 100.0f;
    private string _c = "100";
    public static (int, float, string) GetData(int a, float b, string c)
    {
        return (a ,b, c);
    }

    public void Deconstruct(out int a, out float b, out string c)
    {
        a = _a;
        b = _b;
        c = _c;
    }
}