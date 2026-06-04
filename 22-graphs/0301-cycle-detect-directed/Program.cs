const int N = 3;
var adj = new List<int>[N];
for (int i = 0; i < N; i++) adj[i] = new();
void Add(int u, int v) => adj[u].Add(v);
Add(0, 1); Add(1, 2); Add(2, 0);

var color = new int[N]; // 0=white, 1=gray, 2=black
bool HasCycle(int u)
{
    color[u] = 1;
    foreach (var v in adj[u])
    {
        if (color[v] == 1) return true;
        if (color[v] == 0 && HasCycle(v)) return true;
    }
    color[u] = 2;
    return false;
}

bool cycle = Enumerable.Range(0, N).Any(i => color[i] == 0 && HasCycle(i));
Console.WriteLine(cycle ? "cycle" : "acyclic");
