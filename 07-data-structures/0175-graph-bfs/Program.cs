var adjacency = new List<int>[]
{
    new() { 1, 2 },
    new() { 0, 3 },
    new() { 0, 3 },
    new() { 1, 2 },
};

var visited = new bool[adjacency.Length];
var queue = new Queue<int>();
var order = new List<int>();

queue.Enqueue(0);
visited[0] = true;
while (queue.Count > 0)
{
    int node = queue.Dequeue();
    order.Add(node);
    foreach (var next in adjacency[node])
    {
        if (!visited[next])
        {
            visited[next] = true;
            queue.Enqueue(next);
        }
    }
}

Console.WriteLine(string.Join(" ", order));
