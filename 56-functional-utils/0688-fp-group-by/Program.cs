// Group [1..6] by parity with LINQ's Enumerable.GroupBy, sort keys, then format.
var groups = Enumerable.Range(1, 6)
    .GroupBy(x => x % 2 == 0 ? "even" : "odd")
    .OrderBy(g => g.Key);
Console.WriteLine(string.Join(";", groups.Select(g => $"{g.Key}:{string.Join(",", g)}")));
