// Map x -> x*2 over [1,2,3] using LINQ's Enumerable.Select, then comma-join.
Console.WriteLine(string.Join(",", new[] { 1, 2, 3 }.Select(x => x * 2)));
