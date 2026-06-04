var edges = new (int u, int v, int w)[] { (0, 1, 1), (1, 2, 2), (0, 2, 3) };
const int N = 3;
var parent = Enumerable.Range(0, N).ToArray();
int Find(int x) => parent[x] == x ? x : parent[x] = Find(parent[x]);

int total = 0;
foreach (var (u, v, w) in edges.OrderBy(e => e.w))
{
    int ru = Find(u), rv = Find(v);
    if (ru != rv)
    {
        parent[ru] = rv;
        total += w;
    }
}
Console.WriteLine(total);
