# 0646 — Update a value

Uses the [BitFaster.Caching](https://github.com/bitfaster/BitFaster.Caching) `ClassicLru` strict-LRU cache (capacity 3). Calling `AddOrUpdate` twice on the same key `a` replaces its value rather than adding a second entry, so `TryGet("a")` returns the updated value `2`.

## Run

    dotnet run
