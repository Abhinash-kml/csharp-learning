using System.IO;

static int CheckEntity(Entity ent)
{
    ent switch
    {
        {Health: < 10, Ammo: < 10} => 10,
        {Health: >= 10, Ammo: >= 10} => 20,
        {Health: <= 50, Ammo: <= 50} => 40,
        null => 1000
    };
}

int value = 20;
int calculated = value switch
{
    >= 30 => 300,
    >= 20 => 200,
    _ => 100
};
Console.WriteLine(calculated);

int? meow = null;

if (meow is null)
    Console.WriteLine("Null");

meow = 10;

if (meow is not null)
    Console.WriteLine("Not null");

if (meow is int val)
    Console.WriteLine($"Value = {val}");

State s = State.On;
s switch
{
    State.On => Console.WriteLine("On"),
    State.Off => Console.WriteLine("Off"),
    State.Deafult => Console.WriteLine("Deafault"),
    _ => Console.WriteLine("None")
};

string ss = "neo";
switch (ss)
{
    case "neo":
    Console.WriteLine("neo");
    break;

    case "peo":
    Console.WriteLine("peo");
    break;
}

int entityVal = CheckEntity(new Entity(Health: 10, Ammo: 10));
Console.WriteLine(entityVal);
enum State
{
    Deafult,
    On,
    Off
}
public record class Entity(int Health, int Ammo);