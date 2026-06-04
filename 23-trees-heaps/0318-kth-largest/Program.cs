const int k = 2;
var minHeap = new PriorityQueue<int, int>();

foreach (var v in new[] { 3, 2, 1, 5, 6, 4 })
{
    minHeap.Enqueue(v, v);
    if (minHeap.Count > k) minHeap.Dequeue();
}

Console.WriteLine(minHeap.Peek());
