using BitFaster.Caching.Lru;

static string G(ClassicLru<string, int> c, string k) => c.TryGet(k, out var v) ? v.ToString() : "miss";

// Capacity 3, strict LRU.
var cache = new ClassicLru<string, int>(3);
cache.AddOrUpdate("a", 1);
cache.AddOrUpdate("b", 2);
cache.AddOrUpdate("c", 3);

// GET a promotes `a` to most-recently-used, so `b` becomes the LRU entry.
cache.TryGet("a", out _);

// Adding `d` now evicts `b` (the least-recently-used) instead of `a`.
cache.AddOrUpdate("d", 4);

// get(a) -> 1 (survived thanks to promotion), get(b) -> miss (evicted)
Console.WriteLine(G(cache, "a") + " " + G(cache, "b"));
