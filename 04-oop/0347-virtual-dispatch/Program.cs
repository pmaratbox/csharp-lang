var shapes = new List<Shape> { new Circle(), new Square(), new Triangle() };
Console.WriteLine(string.Join(' ', shapes.Select(s => s.Describe())));

abstract class Shape
{
    public abstract string Describe();
}

class Circle : Shape
{
    public override string Describe() => "circle";
}

class Square : Shape
{
    public override string Describe() => "square";
}

class Triangle : Shape
{
    public override string Describe() => "triangle";
}
