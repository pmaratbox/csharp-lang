var it = new RangeIterator(1, 3);
var parts = new List<int>();
while (it.HasNext())
    parts.Add(it.Next());
Console.WriteLine(string.Join(' ', parts));

sealed class RangeIterator
{
    private readonly int _end;
    private int _current;
    public RangeIterator(int start, int end)
    {
        _current = start;
        _end = end;
    }
    public bool HasNext() => _current <= _end;
    public int Next() => _current++;
}
