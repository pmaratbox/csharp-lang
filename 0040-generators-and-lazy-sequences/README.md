# 0040 — Generators & Lazy Sequences

Produce an endless lazy sequence of squares and take only the first three, printing `1 4 9`. An iterator method using `yield return` produces a lazy `IEnumerable<int>`; each value is computed only as enumeration advances, so `Take(3)` realizes just the first three squares.

## Run

    dotnet run
