using System.IO;

static void Meow(Student s)
{
    s.Describe();
}

Point p = new Point(10.5f, 20.5f);
Console.WriteLine($"Point P - {p.X} - {p.Y}");
Point q = default;
Console.WriteLine($"Point Q - {q.X} - {q.Y}");
Student s = new Student();
s.Describe();
Meow(s);
// s.Name = "Haha";


internal struct Point
{
    public float X { get; set; }
    public float Y { get; set; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}

internal readonly struct Student
{
    public string Name { get; } = "Student 1";
    public string Age { get; init; } = "20";

    public Student() {}
    public Student(string name, string age)
    {
        Name = name;
        Age = age;
    }

    public void Describe()
    {
        Console.WriteLine($"Student - {Name} - {Age}");
    }
}