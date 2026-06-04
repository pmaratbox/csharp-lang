var counts = new Dictionary<char, int>();
var order = new List<char>();
foreach (char c in "aab")
{
    if (!counts.ContainsKey(c)) order.Add(c);
    counts[c] = counts.GetValueOrDefault(c) + 1;
}

Console.WriteLine(string.Join(" ", order.Select(c => $"{c}:{counts[c]}")));
