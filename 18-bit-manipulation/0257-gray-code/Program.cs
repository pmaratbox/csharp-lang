var codes = Enumerable.Range(0, 4).Select(n => n ^ (n >> 1));
Console.WriteLine(string.Join(" ", codes));
