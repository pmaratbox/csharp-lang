# 0025 — Tuples & Multiple Return

Return both the smaller and larger of `3` and `7` from one function, unpacking the pair to print `min: 3` and `max: 7`. A *value tuple* `(int lo, int hi)` returns both results with named elements, and `var (lo, hi) = ...` deconstructs them. Value tuples are lightweight structs; the names are compile-time conveniences over the underlying `Item1`/`Item2`.

## Run

    dotnet run
