# 0531 — Immutable set

Use the in-box `System.Collections.Immutable` library's `ImmutableHashSet<int>`, a persistent set. Calling `.Add(4)` on `{1,2,3}` RETURNS A NEW set of size 4 while the original set stays unchanged at size 3 — the update never mutates in place.

## Run

    dotnet run
