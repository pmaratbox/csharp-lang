var p = new Point(1, 2);
Console.WriteLine(p);

readonly record struct Point(int X, int Y)
{
    public override string ToString() => $"Point(x={X}, y={Y})";
}
