var names = typeof(Point)
    .GetProperties()
    .Select(p => p.Name);

Console.WriteLine(string.Join(' ', names));

record struct Point(int x, int y);
