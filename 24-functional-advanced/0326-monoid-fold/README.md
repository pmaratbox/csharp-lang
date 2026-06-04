# 0326 — Monoid Fold

Fold lists under two monoids: string concat ["a","b","c"]->"abc" and integer sum [1,2,3]->6, printing `abc 6`. One generic `Fold<T>` takes an identity and a combine op for each monoid.

## Run

    dotnet run
