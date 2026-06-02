Point p1 = new(1, 2);
Point p2 = new(1, 2);
Console.WriteLine($"point: ({p1.X}, {p1.Y})");
Console.WriteLine($"equal: {(p1 == p2 ? "yes" : "no")}");

record Point(int X, int Y);
