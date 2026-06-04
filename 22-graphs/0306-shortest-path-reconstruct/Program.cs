const int N = 4;
var adj = new List<(int to, int w)>[N];
for (int i = 0; i < N; i++) adj[i] = new();
void Add(int u, int v, int w) => adj[u].Add((v, w));
Add(0, 1, 4); Add(0, 2, 1); Add(2, 1, 2); Add(1, 3, 1); Add(2, 3, 5);

var dist = Enumerable.Repeat(int.MaxValue, N).ToArray();
var prev = Enumerable.Repeat(-1, N).ToArray();
dist[0] = 0;
var pq = new PriorityQueue<int, int>();
pq.Enqueue(0, 0);
while (pq.TryDequeue(out int u, out int d))
{
    if (d > dist[u]) continue;
    foreach (var (v, w) in adj[u])
        if (dist[u] + w < dist[v])
        {
            dist[v] = dist[u] + w;
            prev[v] = u;
            pq.Enqueue(v, dist[v]);
        }
}

var path = new Stack<int>();
for (int at = 3; at != -1; at = prev[at]) path.Push(at);
Console.WriteLine(string.Join(" ", path));
