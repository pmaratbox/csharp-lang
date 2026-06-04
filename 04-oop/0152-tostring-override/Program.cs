Console.WriteLine(new Point(1, 2));

class Point(int x, int y)
{
    public override string ToString() => $"Point({x}, {y})";
}
