# 0647 — Contains key

Uses the [BitFaster.Caching](https://github.com/bitfaster/BitFaster.Caching) `ClassicLru` strict-LRU cache (capacity 3). After `AddOrUpdate`-ing the key `a` with value `1`, we test membership with `TryGet`, whose boolean result reports a hit: `a` is present (`true`) while the never-stored key `x` is absent (`false`). The two booleans are printed lowercase, space-joined.

## Run

    dotnet run
