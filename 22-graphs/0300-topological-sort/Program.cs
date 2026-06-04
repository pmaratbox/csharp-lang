const int N = 4;
var adj = new List<int>[N];
for (int i = 0; i < N; i++) adj[i] = new();
var indeg = new int[N];
void Add(int u, int v) { adj[u].Add(v); indeg[v]++; }
Add(0, 1); Add(0, 2); Add(1, 3); Add(2, 3);

var ready = new PriorityQueue<int, int>();
for (int i = 0; i < N; i++)
    if (indeg[i] == 0) ready.Enqueue(i, i);

var order = new List<int>();
while (ready.TryDequeue(out int u, out _))
{
    order.Add(u);
    foreach (var v in adj[u])
        if (--indeg[v] == 0) ready.Enqueue(v, v);
}
Console.WriteLine(string.Join(" ", order));
