int[] a = [1, 3, 5];
int[] b = [2, 4, 6];

var merged = a.Zip(b, (x, y) => new[] { x, y }).SelectMany(pair => pair);

Console.WriteLine(string.Join(" ", merged));
