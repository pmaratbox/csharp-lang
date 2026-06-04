using System.Globalization;

var multiset = new MultisetCount();
multiset.Add(1);
multiset.Add(1);
multiset.Add(2);
var first = multiset.Count(1);
multiset.Remove(1);
var second = multiset.Count(1);

Console.WriteLine(string.Join(" ",
    first.ToString(CultureInfo.InvariantCulture),
    second.ToString(CultureInfo.InvariantCulture)));

sealed class MultisetCount
{
    private readonly Dictionary<int, int> counts = new();

    public void Add(int value) =>
        counts[value] = counts.GetValueOrDefault(value) + 1;

    public void Remove(int value)
    {
        if (!counts.TryGetValue(value, out var c))
            return;
        if (c <= 1)
            counts.Remove(value);
        else
            counts[value] = c - 1;
    }

    public int Count(int value) => counts.GetValueOrDefault(value);
}
