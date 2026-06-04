var adjacency = new List<int>[]
{
    new() { 1, 2 },
    new() { 0, 3 },
    new() { 0, 3 },
    new() { 1, 2 },
};

var visited = new bool[adjacency.Length];
var order = new List<int>();

void Dfs(int node)
{
    visited[node] = true;
    order.Add(node);
    foreach (var next in adjacency[node])
        if (!visited[next]) Dfs(next);
}

Dfs(0);
Console.WriteLine(string.Join(" ", order));
