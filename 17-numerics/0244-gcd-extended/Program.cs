static (int g, int x, int y) ExtGcd(int a, int b)
{
    if (b == 0) return (a, 1, 0);
    var (g, x1, y1) = ExtGcd(b, a % b);
    return (g, y1, x1 - (a / b) * y1);
}

var (g, x, y) = ExtGcd(30, 12);

Console.WriteLine($"{g} {x} {y}");
