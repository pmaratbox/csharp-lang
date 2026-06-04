const int N = 4;
var adj = new List<(int to, int w)>[N];
for (int i = 0; i < N; i++) adj[i] = new();
void Add(int u, int v, int w) { adj[u].Add((v, w)); adj[v].Add((u, w)); }
Add(0, 1, 1); Add(1, 2, 2); Add(2, 3, 3);

var inTree = new bool[N];
var pq = new PriorityQueue<(int node, int w), int>();
pq.Enqueue((0, 0), 0);
int total = 0;
while (pq.TryDequeue(out var item, out _))
{
    var (node, w) = item;
    if (inTree[node]) continue;
    inTree[node] = true;
    total += w;
    foreach (var (to, ew) in adj[node])
        if (!inTree[to]) pq.Enqueue((to, ew), ew);
}
Console.WriteLine(total);
