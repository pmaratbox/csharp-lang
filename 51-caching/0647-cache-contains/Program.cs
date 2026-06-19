using BitFaster.Caching.Lru;

var cache = new ClassicLru<string, int>(3);
cache.AddOrUpdate("a", 1);

var hasA = cache.TryGet("a", out _);
var hasX = cache.TryGet("x", out _);

Console.WriteLine($"{hasA.ToString().ToLower()} {hasX.ToString().ToLower()}");
