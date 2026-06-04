int[] data = { 1, 2, 3, 4, 5 };
int n = data.Length;
var tree = new int[2 * n];

// Leaves at [n, 2n); internal nodes built bottom-up.
for (int i = 0; i < n; i++) tree[n + i] = data[i];
for (int i = n - 1; i > 0; i--) tree[i] = tree[2 * i] + tree[2 * i + 1];

static int Query(int[] tree, int n, int l, int r)
{
    int sum = 0;
    for (l += n, r += n + 1; l < r; l >>= 1, r >>= 1)
    {
        if ((l & 1) == 1) sum += tree[l++];
        if ((r & 1) == 1) sum += tree[--r];
    }
    return sum;
}

Console.WriteLine(Query(tree, n, 1, 3));
