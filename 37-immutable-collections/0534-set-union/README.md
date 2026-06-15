# 0534 — Set union

Use System.Collections.Immutable's `ImmutableHashSet<int>` to hold two persistent sets `{1,2,3}` and `{3,4,5}`. Calling `.Union(b)` RETURNS A NEW set containing the combined elements while the original sets stay unchanged. The result is sorted with `OrderBy` and space-joined for deterministic output.

## Run

    dotnet run
