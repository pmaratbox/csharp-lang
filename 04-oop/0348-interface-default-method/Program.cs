IGreeter a = new Defaulted();
Overrider b = new Overrider();
Console.WriteLine($"{a.Greet()} {b.Greet()}");

interface IGreeter
{
    string Greet() => "hi";
}

class Defaulted : IGreeter { }

class Overrider : IGreeter
{
    public string Greet() => "hey";
}
