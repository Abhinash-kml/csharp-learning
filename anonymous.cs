using System.IO;

// Basic anonymous type created using object initializer syntax
var student = new { Name = "Student1", Class = 10};
Console.WriteLine($"Name = {student.Name} | Class = {student.Class}");

// Embedding a variable inside an anonymous type
var human = new { student };
Console.WriteLine($"Name = {human.student.Name} | Class = {human.student.Class}");

// Type with the same fileds and values get same internal type by compiler so it has 
// Equals method for equality checks which checks by value
var student2 = new { Name = "Student1", Class = 10};
Console.WriteLine($"Both the students are {student2.Equals(student)}");

// Nested anonymous type
var order = new
{
    Id = Guid.CreateVersion7(),
    State = "Kolkata",
    Customer = new { Name = "Customer1", Age = 10 }
};
Console.WriteLine(order.ToString());