using System.IO;

// Nullish type
int? a = 10;
Console.WriteLine(a);
if (a is null)
    Console.WriteLine("a is null");
else
    Console.WriteLine(a);

// Unary Null conditional operator = checks if left operand is not null
// then only executes right operand or it doesnt
Console.WriteLine(a?.ToString());

// Binary null coallescing operator
// Evaluates left operand and returns its value if its not null else returns right one
int b = a ?? 100;
Console.WriteLine(b);
