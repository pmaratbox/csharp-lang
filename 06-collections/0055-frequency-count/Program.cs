var word = "banana";
var counts = new SortedDictionary<char, int>();
foreach (var ch in word)
{
    counts[ch] = counts.GetValueOrDefault(ch, 0) + 1;
}

Console.WriteLine(string.Join(" ", counts.Select(kv => $"{kv.Key}:{kv.Value}")));
