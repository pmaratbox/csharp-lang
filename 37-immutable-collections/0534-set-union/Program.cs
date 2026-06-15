using System.Collections.Immutable;

ImmutableHashSet<int> a = ImmutableHashSet.Create(1, 2, 3);
ImmutableHashSet<int> b = ImmutableHashSet.Create(3, 4, 5);

// Union returns a NEW set; 'a' is left unchanged.
ImmutableHashSet<int> union = a.Union(b);

Console.WriteLine(string.Join(" ", union.OrderBy(x => x)));
