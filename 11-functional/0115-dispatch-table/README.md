# 0115 — Dispatch Table

Store functions in a map keyed by name, then apply "add" and "mul" to (3,4), printing `7 12`. A `Dictionary<string, Func<int, int, int>>` holds the operations as first-class delegates you look up by key and invoke.

## Run

    dotnet run
