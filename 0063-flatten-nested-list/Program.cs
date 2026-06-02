var nested = new[] { new[] { 1, 2 }, new[] { 3, 4 } };
var flat = nested.SelectMany(row => row);
Console.WriteLine(string.Join(" ", flat));
