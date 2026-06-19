# 0642 — Cache miss

Uses the [BitFaster.Caching](https://github.com/bitfaster/BitFaster.Caching) `ClassicLru` strict-LRU cache (capacity 3). Looking up key `x` in an empty cache, `TryGet` returns `false`, so our helper prints `miss` — the standard signal for a cache miss.

## Run

    dotnet run
