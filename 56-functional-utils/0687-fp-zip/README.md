# 0687 — Zip

This lesson uses LINQ (the .NET standard query library, `System.Linq`) and its `Zip` transform to combine two sequences element-by-element. We zip `[1,2,3]` with `["a","b","c"]`, formatting each pair as `<n><s>` via `Zip(other, (n, s) => $"{n}{s}")`, then comma-join to produce `1a,2b,3c`.

## Run

    dotnet run
