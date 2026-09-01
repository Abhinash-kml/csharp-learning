using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// List -- dynamic array
List<int> l1 = [1, 2, 3, 4, 5];
Console.WriteLine(string.Join(", ", l1));
l1.AddRange([6, 7, 8, 9, 10]);
Console.WriteLine(string.Join(", ", l1));
bool exists = l1.Contains(10);
Console.WriteLine($"{exists}");
exists = l1.Contains(100);
Console.WriteLine($"{exists}");
exists = l1.Exists((x) => x % 11 == 0);
Console.WriteLine($"{exists}");
l1.Add(11);
Console.WriteLine(string.Join(", ", l1));
l1.Remove(11);
l1.RemoveAll(x => x % 2 == 0);
Console.WriteLine(string.Join(", ", l1));
l1.ForEach(x => x += 6);
Console.WriteLine(string.Join(", ", l1));
Dictionary<int, int> d = l1.ToDictionary<int, int>(x => x);
foreach (var (key, value) in d)
    Console.WriteLine($"{key}-{value}");

Console.WriteLine("---------------------------------------");

// Dictionary
Dictionary<int, string> d1 = new();
d1[1] = "1";
d1.Add(2, "2");
if (d1.TryAdd(3, "3"))
    Console.WriteLine("Added");

foreach (var (key, value) in d1)
    Console.WriteLine($"{key}-{value}");

Console.WriteLine(d1.ContainsKey(4));
Console.WriteLine(d1.ContainsValue("4"));

// Queue


// Set