foreach (Shape shape in new Shape[] { new Rect(2, 3), new Square(4) })
{
    Console.WriteLine(Area(shape));
}

static int Area(Shape shape) => shape switch
{
    Rect r => r.W * r.H,
    Square s => s.S * s.S,
    _ => 0,
};

abstract record Shape;
record Rect(int W, int H) : Shape;
record Square(int S) : Shape;
