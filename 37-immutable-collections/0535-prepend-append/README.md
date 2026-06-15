# 0535 — Prepend & append

Use `System.Collections.Immutable`'s `ImmutableList<T>` (a persistent collection): starting from `[2, 3]`, `Insert(0, 1)` prepends and `Add(4)` appends. Each operation returns a brand-new list while the original stays unchanged, so the final list prints as `1 2 3 4`.

## Run

    dotnet run
