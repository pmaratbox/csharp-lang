using System.Collections.Immutable;

// ImmutableHashSet is a persistent set: Add returns a NEW set, the original is unchanged.
ImmutableHashSet<int> original = ImmutableHashSet.Create(1, 2, 3);
ImmutableHashSet<int> updated = original.Add(4);

// The new set has 4 elements; the original still has 3.
Console.WriteLine(updated.Count);
Console.WriteLine(original.Count);
