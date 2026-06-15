using Sprache;

// Parse digits into an int, then MAP that value to value * 2 with .Select.
var doubled = Parse.Number.Select(int.Parse).Select(n => n * 2);

Console.WriteLine(doubled.Parse("21"));
