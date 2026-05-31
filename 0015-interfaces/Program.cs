List<IShape> shapes = [new Rectangle(3, 4), new Square(5)];
foreach (IShape s in shapes)
{
    Console.WriteLine($"{s.Name()} area: {s.Area()}");
}

interface IShape
{
    string Name();
    int Area();
}

record Rectangle(int Width, int Height) : IShape
{
    public string Name() => "rectangle";
    public int Area() => Width * Height;
}

record Square(int Side) : IShape
{
    public string Name() => "square";
    public int Area() => Side * Side;
}
