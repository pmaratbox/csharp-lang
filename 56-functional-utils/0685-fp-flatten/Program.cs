var nested = new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } };
var flat = nested.SelectMany(inner => inner);
Console.WriteLine(string.Join(",", flat));
