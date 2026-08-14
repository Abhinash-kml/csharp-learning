using System.Data.Common;
using System.IO;
using System.Net.Cache;
using Microsoft.VisualBasic;

var req = new Request("aaa", 10);
var res = new Response("aaa", "meow meow");

var (id, dat) = req;
Console.WriteLine($"Request id {id} and num {dat}");

Request r = new("aaa", 10);
if (req == r) 
{
    Console.WriteLine("Req and r is equal");
    Console.WriteLine($"{r.id} - {r.value}");
}

// Assigning record class object to another copies reference and not data
var p1 = new Request("bbb", 11);
var p2 = p1;
Console.WriteLine(ReferenceEquals(p1, p2));

// Assigning record struct object to another copies data and nit reference
var m1 = new Meow("Hitler", 3);
var m2 = m1;
Console.WriteLine($"m1.Name = {m1.Name} | m2.Name = {m2.Name}");
Console.WriteLine(Equals(m1, m2));
Console.WriteLine(m1 == m2);

// Non destructive copy mutation with "with" keyword
var cm = m1 with {Name = "Hitlet2"};
Console.WriteLine($"Non destructive copy mutation using with key. Cam value = {cm.Name} - {cm.Age}");

// Record inheritance
var student = new Student("Rahul", 50);
Console.WriteLine($"Student - {student.NewName} - {student.NewAge}\nHuman - {student.Name} - {student.Age}");
record Request(string id, int value);
record Response(string id, string data);

record struct Meow(string Name, int Age);

public record class Human(string Name = "Human", int Age = 10);
public record class Student(string NewName, int NewAge)
                    : Human(NewName, NewAge);