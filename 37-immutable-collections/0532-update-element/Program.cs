using System.Collections.Immutable;

var original = ImmutableList.Create(1, 2, 3);
var updated = original.SetItem(0, 99);

Console.WriteLine(string.Join(" ", updated));
Console.WriteLine(string.Join(" ", original));
