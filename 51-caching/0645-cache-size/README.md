# 0645 — Cache size

Uses the [BitFaster.Caching](https://github.com/bitfaster/BitFaster.Caching) `ClassicLru` strict-LRU cache (capacity 5). We `AddOrUpdate` two entries `a=1` and `b=2`, then read the live entry count via `Count` — well under capacity, so both remain — printing `2`.

## Run

    dotnet run
