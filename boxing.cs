using System.IO;

int num = 10;
object box = num;
int unboxed = (int)box;
Console.WriteLine(unboxed);