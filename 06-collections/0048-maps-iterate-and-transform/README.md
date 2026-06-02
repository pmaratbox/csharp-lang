# 0048 — Maps: Iterate & Transform

Build a map from letters to numbers (`a`->1, `b`->2, `c`->3), sum all its values, and print `sum: 6`. `Dictionary<string, int>` exposes a `.Values` collection that LINQ's `Sum` folds. `foreach (var kv in dict)`, `.Keys`, and `.Values` are the traversal options.

## Run

    dotnet run
