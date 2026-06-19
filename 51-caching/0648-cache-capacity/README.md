# 0648 — Capacity bound

Uses the [BitFaster.Caching](https://github.com/bitfaster/BitFaster.Caching) `ClassicLru` strict-LRU cache (capacity 3). We `AddOrUpdate` four keys `a`, `b`, `c`, `d`, but the cache never holds more entries than its capacity — the least-recently-used key is evicted as new ones arrive — so `Count` prints `3`.

## Run

    dotnet run
