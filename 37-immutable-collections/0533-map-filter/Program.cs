using System.Collections.Immutable;

ImmutableList<int> source = ImmutableList.Create(1, 2, 3, 4, 5);

// Filter then map, each step returning a NEW immutable list.
ImmutableList<int> evens = source.Where(n => n % 2 == 0).ToImmutableList();
ImmutableList<int> result = evens.Select(n => n * 10).ToImmutableList();

Console.WriteLine(string.Join(" ", result));
