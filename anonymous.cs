using System.IO;

// Basic anonymous type created using object initializer syntax
var student = new { Name = "Student1", Class = 10};
Console.WriteLine($"Name = {student.Name} | Class = {student.Class}");

// Embedding a variable inside an anonymous type
var human = new { student };
Console.WriteLine($"Name = {human.student.Name} | Class = {human.student.Class}");