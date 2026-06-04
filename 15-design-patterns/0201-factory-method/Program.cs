var a = Create("circle");
var b = Create("square");
Console.WriteLine($"{a.Kind} {b.Kind}");

static IShape Create(string name) => name switch
{
    "circle" => new Circle(),
    "square" => new Square(),
    _ => throw new ArgumentException($"unknown shape: {name}"),
};

interface IShape { string Kind { get; } }

sealed class Circle : IShape { public string Kind => "circle"; }
sealed class Square : IShape { public string Kind => "square"; }
