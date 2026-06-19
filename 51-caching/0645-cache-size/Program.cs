using BitFaster.Caching.Lru;

var cache = new ClassicLru<string, int>(5);
cache.AddOrUpdate("a", 1);
cache.AddOrUpdate("b", 2);
Console.WriteLine(cache.Count);
