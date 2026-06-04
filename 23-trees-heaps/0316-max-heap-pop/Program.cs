var heap = new PriorityQueue<int, int>();
foreach (var v in new[] { 3, 1, 4, 1, 5 })
    heap.Enqueue(v, -v); // negate priority for max-heap behavior

var top = new List<int>();
for (int i = 0; i < 3; i++)
    top.Add(heap.Dequeue());

Console.WriteLine(string.Join(" ", top));
