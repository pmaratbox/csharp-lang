using BitFaster.Caching.Lru;

static string G(ClassicLru<string, int> c, string k) => c.TryGet(k, out var v) ? v.ToString() : "miss";

// Capacity 3, strict LRU. Insert a,b,c,d with no gets between:
// `a` is the least-recently-used and is evicted when `d` is added.
var cache = new ClassicLru<string, int>(3);
cache.AddOrUpdate("a", 1);
cache.AddOrUpdate("b", 2);
cache.AddOrUpdate("c", 3);
cache.AddOrUpdate("d", 4);

// get(a) -> miss (evicted), get(d) -> 4
Console.WriteLine(G(cache, "a") + " " + G(cache, "d"));
