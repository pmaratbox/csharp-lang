Point p1 = new(1, 2);
Point p2 = p1 with { X = 9 };
Console.WriteLine($"original: ({p1.X}, {p1.Y})");
Console.WriteLine($"updated: ({p2.X}, {p2.Y})");

record Point(int X, int Y);
