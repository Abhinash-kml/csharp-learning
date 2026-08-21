using System.IO;

State s = State.Default;
State open = State.Open;
State closed = State.Closed;

EWithType Default = EWithType.Default;
EWithType Open = EWithType.Open;
EWithType Closed = EWithType.Closed;

foreach (var values in Enum.GetValues<EWithType>())
    Console.WriteLine(values);

var parsed = Enum.Parse<EWithType>("Default");
Console.WriteLine($"Parsed enum = {parsed}");
// parsed = Enum.Parse<EWithType>("Meow");
// Console.WriteLine(parsed);

enum State
{
    Default,
    Open,
    Closed
}

enum EWithType : int
{
    Default,
    Open,
    Closed
}
