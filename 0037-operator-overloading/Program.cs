Point p = new Point(1, 2) + new Point(3, 4);
Console.WriteLine($"({p.X}, {p.Y})");

record Point(int X, int Y)
{
    public static Point operator +(Point a, Point b) => new(a.X + b.X, a.Y + b.Y);
}
