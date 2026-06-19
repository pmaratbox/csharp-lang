// Flat map with LINQ's SelectMany: map each element to a sequence, then flatten.
Console.WriteLine(string.Join(",", new[] { 1, 2, 3 }.SelectMany(x => new[] { x, x * 10 })));
