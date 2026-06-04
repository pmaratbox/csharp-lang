var factory = new GlyphFactory();
foreach (var c in "aba")
    factory.Get(c);
Console.WriteLine(factory.Created);

sealed class Glyph
{
    public char Symbol { get; }
    public Glyph(char symbol) => Symbol = symbol;
}

sealed class GlyphFactory
{
    private readonly Dictionary<char, Glyph> _cache = new();
    public int Created => _cache.Count;
    public Glyph Get(char symbol)
    {
        if (!_cache.TryGetValue(symbol, out var glyph))
        {
            glyph = new Glyph(symbol);
            _cache[symbol] = glyph;
        }
        return glyph;
    }
}
