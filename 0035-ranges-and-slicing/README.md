# 0035 — Ranges & Slicing

From the list `[10, 20, 30, 40, 50]`, take the sub-sequence at indices 1 through 4 (exclusive) and print `slice: 20 30 40`. The range operator `nums[1..4]` uses half-open `Index`/`Range` values; on an array it allocates a new array, while `AsSpan()[1..4]` gives a non-allocating `Span<T>` view. `^1` indexes from the end.

## Run

    dotnet run
