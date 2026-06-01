# 0024 — Sorting & Comparators

Sort `[3, 1, 2]` ascending, then again with a custom comparator that reverses the order, printing `asc: 1 2 3` and `desc: 3 2 1`. `Array.Sort` orders an array in place by default comparison; an overload takes a `Comparison<int>` delegate, and `(a, b) => b.CompareTo(a)` reverses it. LINQ's `OrderBy`/`OrderByDescending` instead return a new sorted sequence.

## Run

    dotnet run
