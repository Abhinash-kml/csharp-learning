using System.IO;

State s = State.Default;
State open = State.Open;
State closed = State.Closed;

EWithType Default = EWithType.Default;
EWithType Open = EWithType.Open;
EWithType Closed = EWithType.Closed;

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
