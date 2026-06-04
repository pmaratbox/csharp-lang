int[] xs = [1, 2, 3, 4];

var pairs = xs.Zip(xs.Skip(1), (a, b) => $"{a},{b}");

Console.WriteLine(string.Join(" ", pairs));
