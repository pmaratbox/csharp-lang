var heap = new MinHeap();
foreach (var v in new[] { 3, 1, 2 }) heap.Push(v);

var result = new List<int>();
while (heap.Count > 0) result.Add(heap.Pop());
Console.WriteLine(string.Join(" ", result));

class MinHeap
{
    private readonly List<int> _items = new();
    public int Count => _items.Count;

    public void Push(int value)
    {
        _items.Add(value);
        int i = _items.Count - 1;
        while (i > 0)
        {
            int parent = (i - 1) / 2;
            if (_items[parent] <= _items[i]) break;
            (_items[parent], _items[i]) = (_items[i], _items[parent]);
            i = parent;
        }
    }

    public int Pop()
    {
        int top = _items[0];
        int last = _items.Count - 1;
        _items[0] = _items[last];
        _items.RemoveAt(last);
        int i = 0, n = _items.Count;
        while (true)
        {
            int l = 2 * i + 1, r = 2 * i + 2, smallest = i;
            if (l < n && _items[l] < _items[smallest]) smallest = l;
            if (r < n && _items[r] < _items[smallest]) smallest = r;
            if (smallest == i) break;
            (_items[smallest], _items[i]) = (_items[i], _items[smallest]);
            i = smallest;
        }
        return top;
    }
}
