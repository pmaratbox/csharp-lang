# 0359 — Flatten Deeply

Flatten the arbitrarily nested structure [1,[2,[3,4]],5] into `1 2 3 4 5`. A recursive iterator pattern-matches each node on `List<object>` and `yield return`s scalars in order.

## Run

    dotnet run
