const int N = 3;
const int INF = 1_000_000;
var dist = new int[N, N];
for (int i = 0; i < N; i++)
    for (int j = 0; j < N; j++)
        dist[i, j] = i == j ? 0 : INF;
void Add(int u, int v, int w) => dist[u, v] = w;
Add(0, 1, 3); Add(1, 2, 1); Add(0, 2, 5);

for (int k = 0; k < N; k++)
    for (int i = 0; i < N; i++)
        for (int j = 0; j < N; j++)
            if (dist[i, k] + dist[k, j] < dist[i, j])
                dist[i, j] = dist[i, k] + dist[k, j];

Console.WriteLine(dist[0, 2]);
