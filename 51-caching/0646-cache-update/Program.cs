using BitFaster.Caching.Lru;

static string Get(ClassicLru<string, int> cache, string key) =>
    cache.TryGet(key, out var value) ? value.ToString() : "miss";

var cache = new ClassicLru<string, int>(3);
cache.AddOrUpdate("a", 1);
cache.AddOrUpdate("a", 2);
Console.WriteLine(Get(cache, "a"));
