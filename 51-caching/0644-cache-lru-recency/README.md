# 0644 — Recency promotion

Uses the **BitFaster.Caching** `ClassicLru<string,int>` (a strict LRU cache) with capacity 3. After inserting `a,b,c`, a `TryGet("a")` promotes `a` to most-recently-used, making `b` the least-recently-used entry. Adding `d` therefore evicts `b` rather than `a`, so looking them up afterward prints `1 miss`.

## Run

    dotnet run
