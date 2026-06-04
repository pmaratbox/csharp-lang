const int N = 5;
var parent = Enumerable.Range(0, N).ToArray();
int Find(int x) => parent[x] == x ? x : parent[x] = Find(parent[x]);
void Union(int a, int b) => parent[Find(a)] = Find(b);
Union(0, 1); Union(1, 2); Union(3, 4);

int count = Enumerable.Range(0, N).Count(i => Find(i) == i);
Console.WriteLine(count);
