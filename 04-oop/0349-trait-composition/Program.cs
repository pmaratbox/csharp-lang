IA a = new Composed();
IB b = (IB)a;
Console.WriteLine($"{a.DoA()} {b.DoB()}");

interface IA
{
    string DoA() => "a";
}

interface IB
{
    string DoB() => "b";
}

class Composed : IA, IB { }
