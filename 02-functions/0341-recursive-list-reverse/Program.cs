using System.Globalization;

List<int> RecursiveReverse(ReadOnlySpan<int> xs)
{
    if (xs.IsEmpty) return [];
    var rest = RecursiveReverse(xs[1..]);
    rest.Add(xs[0]);
    return rest;
}

var reversed = RecursiveReverse([1, 2, 3]);
Console.WriteLine(string.Join(" ", reversed.Select(n => n.ToString(CultureInfo.InvariantCulture))));
