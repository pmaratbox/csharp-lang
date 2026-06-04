using System.Globalization;

var cache = new LruCache(2);
cache.Put(1, 1);
cache.Put(2, 2);
cache.Get(1);
cache.Put(3, 3); // evicts key 2

Console.WriteLine(string.Join(" ",
    cache.Get(1).ToString(CultureInfo.InvariantCulture),
    cache.Get(2).ToString(CultureInfo.InvariantCulture)));

sealed class LruCache(int capacity)
{
    private readonly Dictionary<int, LinkedListNode<(int Key, int Value)>> map = new();
    private readonly LinkedList<(int Key, int Value)> order = new();

    public int Get(int key)
    {
        if (!map.TryGetValue(key, out var node))
            return -1;
        order.Remove(node);
        order.AddFirst(node);
        return node.Value.Value;
    }

    public void Put(int key, int value)
    {
        if (map.TryGetValue(key, out var existing))
        {
            order.Remove(existing);
            map.Remove(key);
        }
        else if (map.Count >= capacity)
        {
            var last = order.Last!;
            order.RemoveLast();
            map.Remove(last.Value.Key);
        }
        var node = order.AddFirst((key, value));
        map[key] = node;
    }
}
