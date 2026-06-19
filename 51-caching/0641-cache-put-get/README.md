# 0641 — Put and get

Uses the [BitFaster.Caching](https://github.com/bitfaster/BitFaster.Caching) `ClassicLru` strict-LRU cache (capacity 3). We `AddOrUpdate` the key `a` with value `1`, then `TryGet` it back — a successful lookup also promotes the key to most-recently-used — printing the stored value `1`.

## Run

    dotnet run
