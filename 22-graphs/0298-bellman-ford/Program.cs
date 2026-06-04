var edges = new (int u, int v, int w)[] { (0, 1, 1), (1, 2, -2), (0, 2, 4) };
const int N = 3;
var dist = Enumerable.Repeat(int.MaxValue, N).ToArray();
dist[0] = 0;
for (int i = 0; i < N - 1; i++)
    foreach (var (u, v, w) in edges)
        if (dist[u] != int.MaxValue && dist[u] + w < dist[v])
            dist[v] = dist[u] + w;
Console.WriteLine(string.Join(" ", dist));
