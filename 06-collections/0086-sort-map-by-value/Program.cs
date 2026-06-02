var scores = new Dictionary<string, int> { ["a"] = 3, ["b"] = 1, ["c"] = 2 };
var sorted = scores.OrderBy(kv => kv.Value);
Console.WriteLine(string.Join(" ", sorted.Select(kv => $"{kv.Key}:{kv.Value}")));
