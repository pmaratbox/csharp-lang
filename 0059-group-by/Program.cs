var words = new[] { "one", "two", "three" };
var groups = words
    .GroupBy(w => w.Length)
    .OrderBy(g => g.Key);

Console.WriteLine(string.Join(" ", groups.Select(g => $"{g.Key}:[{string.Join(",", g)}]")));
