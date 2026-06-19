# 0643 — LRU eviction

Uses the **BitFaster.Caching** `ClassicLru<string,int>` (a strict LRU cache) with capacity 3. Inserting `a,b,c,d` with no intervening lookups makes `a` the least-recently-used entry, so it is evicted when `d` is added. Looking it up returns a miss while `d` is still present: `miss 4`.

## Run

    dotnet run
