var a = new Point();
var b = new Point { X = 5 };

Console.WriteLine($"{a.X} {a.Y}");
Console.WriteLine($"{b.X} {b.Y}");

struct Point
{
    public int X = 0;
    public int Y = 0;
    public Point() { }
}
