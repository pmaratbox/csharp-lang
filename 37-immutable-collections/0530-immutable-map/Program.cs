using System.Collections.Immutable;

var original = ImmutableDictionary<string, int>.Empty.Add("a", 1);
var updated = original.SetItem("b", 2);

Console.WriteLine(string.Join(" ", updated.Keys.OrderBy(k => k)));
Console.WriteLine(string.Join(" ", original.Keys.OrderBy(k => k)));
