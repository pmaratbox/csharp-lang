Console.WriteLine(new Square(3).Describe());

abstract class Shape
{
    public abstract int Area();
    public string Describe() => $"area: {Area()}";
}

class Square(int side) : Shape
{
    public override int Area() => side * side;
}
