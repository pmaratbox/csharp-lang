int[] xs = [1, 1, 2, 3, 3, 3];

var ordered = xs
    .GroupBy(x => x)
    .OrderByDescending(g => g.Count())
    .SelectMany(g => g);

Console.WriteLine(string.Join(" ", ordered));
