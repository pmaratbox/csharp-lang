var m = new Dictionary<string, int> { ["a"] = 1, ["b"] = 2, ["c"] = 3 };
var inverted = m.ToDictionary(kv => kv.Value, kv => kv.Key);
Console.WriteLine(string.Join(" ", inverted.OrderBy(kv => kv.Key).Select(kv => $"{kv.Key}:{kv.Value}")));
