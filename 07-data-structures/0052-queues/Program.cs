var queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

var parts = new List<string>();
while (queue.Count > 0)
{
    parts.Add(queue.Dequeue().ToString());
}
Console.WriteLine(string.Join(" ", parts));
