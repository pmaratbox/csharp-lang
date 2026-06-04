var uf = new UnionFind(4);
uf.Union(0, 1);
uf.Union(2, 3);
Console.WriteLine($"{(uf.Connected(0, 1) ? "yes" : "no")} {(uf.Connected(0, 2) ? "yes" : "no")}");

class UnionFind
{
    private readonly int[] _parent;

    public UnionFind(int n)
    {
        _parent = new int[n];
        for (int i = 0; i < n; i++) _parent[i] = i;
    }

    public int Find(int x) => _parent[x] == x ? x : _parent[x] = Find(_parent[x]);

    public void Union(int a, int b) => _parent[Find(a)] = Find(b);

    public bool Connected(int a, int b) => Find(a) == Find(b);
}
