var labels = new[] { 1, 2, 3, 4 }.Select(n => n % 2 == 0 ? "even" : "odd");
Console.WriteLine(string.Join(' ', labels));
