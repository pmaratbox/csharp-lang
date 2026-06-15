using System.Collections.Immutable;

// Immutable map { user: { age: 30 } }.
var inner = ImmutableDictionary<string, int>.Empty.SetItem("age", 30);
var outer = ImmutableDictionary<string, ImmutableDictionary<string, int>>.Empty.SetItem("user", inner);

// Update the nested user.age to 31. Each SetItem RETURNS A NEW map;
// the originals (inner / outer) stay unchanged.
var updatedInner = outer["user"].SetItem("age", 31);
var updatedOuter = outer.SetItem("user", updatedInner);

Console.WriteLine(updatedOuter["user"]["age"]); // 31 (new)
Console.WriteLine(outer["user"]["age"]);        // 30 (original, unchanged)
