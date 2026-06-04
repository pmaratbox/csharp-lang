const int N = 4;
var adj = new List<int>[N];
for (int i = 0; i < N; i++) adj[i] = new();
void Add(int u, int v) => adj[u].Add(v);
Add(0, 1); Add(1, 2); Add(2, 0); Add(2, 3);

var index = new int[N];
var low = new int[N];
var onStack = new bool[N];
Array.Fill(index, -1);
var stack = new Stack<int>();
int counter = 0, sccCount = 0;

void Strongconnect(int v)
{
    index[v] = low[v] = counter++;
    stack.Push(v);
    onStack[v] = true;
    foreach (var w in adj[v])
    {
        if (index[w] == -1) { Strongconnect(w); low[v] = Math.Min(low[v], low[w]); }
        else if (onStack[w]) low[v] = Math.Min(low[v], index[w]);
    }
    if (low[v] == index[v])
    {
        sccCount++;
        int w;
        do { w = stack.Pop(); onStack[w] = false; } while (w != v);
    }
}

for (int v = 0; v < N; v++)
    if (index[v] == -1) Strongconnect(v);

Console.WriteLine(sccCount);
