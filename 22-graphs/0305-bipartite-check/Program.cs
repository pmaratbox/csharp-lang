bool IsBipartite(int n, (int, int)[] edges)
{
    var adj = new List<int>[n];
    for (int i = 0; i < n; i++) adj[i] = new();
    foreach (var (u, v) in edges) { adj[u].Add(v); adj[v].Add(u); }

    var color = new int[n];
    Array.Fill(color, -1);
    for (int s = 0; s < n; s++)
    {
        if (color[s] != -1) continue;
        color[s] = 0;
        var q = new Queue<int>();
        q.Enqueue(s);
        while (q.Count > 0)
        {
            int u = q.Dequeue();
            foreach (var v in adj[u])
            {
                if (color[v] == -1) { color[v] = color[u] ^ 1; q.Enqueue(v); }
                else if (color[v] == color[u]) return false;
            }
        }
    }
    return true;
}

var square = new (int, int)[] { (0, 1), (1, 2), (2, 3), (3, 0) };
var triangle = new (int, int)[] { (0, 1), (1, 2), (2, 0) };
Console.WriteLine($"{(IsBipartite(4, square) ? "yes" : "no")} {(IsBipartite(3, triangle) ? "yes" : "no")}");
