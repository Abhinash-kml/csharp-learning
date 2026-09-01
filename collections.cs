using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
Queue<int> q1 = new();
q1.Enqueue(1);
q1.Enqueue(2);
q1.Enqueue(3);
q1.Enqueue(4);
q1.Enqueue(5);
Console.WriteLine(string.Join(", ", q1));
q1.Dequeue();
Console.WriteLine(string.Join(", ", q1));
Console.WriteLine(q1.Capacity);
Console.WriteLine(q1.Count);
q1.Clear();
Console.WriteLine(string.Join(", ", q1));

// Set
HashSet<int> s1 = new();
s1.Add(1);
s1.Add(2);
s1.Add(3);
Console.WriteLine(string.Join(", ", s1));
s1.Add(1);
s1.Add(2);
Console.WriteLine(string.Join(", ", s1));
Console.WriteLine(s1.Contains(2));
s1.Remove(3);
Console.WriteLine(string.Join(", ", s1));
s1.Clear();
Console.WriteLine(string.Join(", ", s1));

// String
string str1 = "I am a very good boy";
Console.WriteLine(string.IsNullOrEmpty(str1));
foreach (var c in str1)
    Console.Write(c);
Console.Write('\n');

Console.WriteLine(str1.Length);
Console.WriteLine(str1.Contains("am"));

string[] parts = str1.Split(" ");
foreach (var part in parts)
    Console.Write(part);
Console.Write('\n');

Console.WriteLine(str1.Substring(4));
Console.WriteLine(str1 + str1.Substring(4));
str1 += "And you know that";
Console.WriteLine(str1);
Console.WriteLine(str1.ToLower());
Console.WriteLine(str1.ToUpper());

// Encoding
byte[] bytesU8 = Encoding.UTF8.GetBytes(str1);
foreach (var b in bytesU8)
    Console.Write(b);
Console.WriteLine();

byte[] byteASCII = Encoding.ASCII.GetBytes(str1);
foreach (var b in byteASCII)
    Console.Write(b);
Console.WriteLine();

byte[] byteUNICODE = Encoding.Unicode.GetBytes(str1);
foreach (var b in byteUNICODE)
    Console.Write(b);
Console.WriteLine();

// Decoding
Console.WriteLine(Encoding.UTF8.GetString(bytesU8));
Console.WriteLine(Encoding.ASCII.GetString(byteASCII));
Console.WriteLine(Encoding.Unicode.GetString(byteUNICODE));
