string[] items = ["a", "b", "a", "c", "b", "a"];

var topK = items
    .GroupBy(x => x)
    .OrderByDescending(g => g.Count())
    .Take(2)
    .Select(g => g.Key);

Console.WriteLine(string.Join(" ", topK));
