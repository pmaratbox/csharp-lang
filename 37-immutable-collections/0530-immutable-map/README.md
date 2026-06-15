# 0530 — Immutable map

Use `System.Collections.Immutable.ImmutableDictionary` (in-box on .NET 10) to build a persistent map `{a:1}`, then call `SetItem("b", 2)`, which RETURNS A NEW map rather than mutating in place. Printing the new map's sorted keys (`a b`) and then the original's sorted keys (`a`) shows the original is unchanged.

## Run

    dotnet run
