# 0533 — Map & filter

Use `System.Collections.Immutable`'s `ImmutableList<int>` (in-box on net10). Starting from `[1,2,3,4,5]`, filter the even values and map each one by `*10`, with every step returning a brand-new immutable list via `.ToImmutableList()` (the original is never mutated). The result is printed space-joined.

## Run

    dotnet run
