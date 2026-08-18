using System.IO;
using Microsoft.VisualBasic;

DateTime now = DateTime.Now;
Console.WriteLine(now);
Console.WriteLine(now.Year);
DateTime newDate = now.AddMinutes(10);
TimeSpan difference = newDate.Subtract(now);
Console.WriteLine(difference);

DateOnly currentDate = DateOnly.FromDateTime(now);
Console.WriteLine(currentDate);
DateOnly addedDate = currentDate.AddDays(5);
Console.WriteLine(addedDate.Equals(currentDate));