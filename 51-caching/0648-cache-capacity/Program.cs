using BitFaster.Caching.Lru;

var cache = new ClassicLru<string, int>(3);
cache.AddOrUpdate("a", 1);
cache.AddOrUpdate("b", 2);
cache.AddOrUpdate("c", 3);
cache.AddOrUpdate("d", 4);
Console.WriteLine(cache.Count);
