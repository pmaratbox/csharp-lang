var pq = new PriorityQueue<int, int>();
foreach (var n in new[] { 3, 1, 2 })
{
    pq.Enqueue(n, n);
}

var parts = new List<string>();
while (pq.Count > 0)
{
    parts.Add(pq.Dequeue().ToString());
}
Console.WriteLine(string.Join(" ", parts));
