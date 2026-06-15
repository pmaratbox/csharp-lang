# 0529 — Immutable list

Using `System.Collections.Immutable` (in-box on .NET 10), create an
`ImmutableList<int>` of `[1, 2, 3]`. Calling `.Add(4)` does not mutate the
list — it RETURNS A NEW `ImmutableList` with the extra element while the
original stays unchanged. Printing the new list shows `1 2 3 4` and printing
the original still shows `1 2 3`.

## Run

    dotnet run
