var left = new Dictionary<string, int> { ["a"] = 1, ["b"] = 2 };
var right = new Dictionary<string, int> { ["b"] = 3, ["c"] = 4 };

var merged = new Dictionary<string, int>(left);
foreach (var (k, v) in right)
    merged[k] = v;

var parts = merged.OrderBy(kv => kv.Key).Select(kv => $"{kv.Key}:{kv.Value}");
Console.WriteLine(string.Join(" ", parts));
