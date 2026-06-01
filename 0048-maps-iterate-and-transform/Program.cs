var scores = new Dictionary<string, int> { ["a"] = 1, ["b"] = 2, ["c"] = 3 };
int total = scores.Values.Sum();
Console.WriteLine($"sum: {total}");
