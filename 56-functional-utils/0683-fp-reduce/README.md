# 0683 — Reduce

This lesson uses LINQ (the .NET standard query library, `System.Linq`) and its `Aggregate` transform to fold a sequence down to a single value. We reduce `[1..5]` with addition starting from a seed of `0` via `Aggregate(0, (sum, x) => sum + x)`, producing `15`.

## Run

    dotnet run
