using System.Collections.Immutable;

// Start with an immutable list [2, 3].
var original = ImmutableList.Create(2, 3);

// Insert at the front (prepend) and add to the back (append).
// Each call RETURNS A NEW list; `original` is never mutated.
var result = original.Insert(0, 1).Add(4);

Console.WriteLine(string.Join(" ", result));
