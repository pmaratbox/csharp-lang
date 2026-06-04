static void SiftDown(int[] a, int start, int end)
{
    int root = start;
    while (2 * root + 1 <= end)
    {
        int child = 2 * root + 1;
        if (child + 1 <= end && a[child] < a[child + 1]) child++;
        if (a[root] >= a[child]) return;
        (a[root], a[child]) = (a[child], a[root]);
        root = child;
    }
}

static void HeapSort(int[] a)
{
    int n = a.Length;
    for (int i = n / 2 - 1; i >= 0; i--) SiftDown(a, i, n - 1);
    for (int end = n - 1; end > 0; end--)
    {
        (a[0], a[end]) = (a[end], a[0]);
        SiftDown(a, 0, end - 1);
    }
}

var data = new[] { 5, 3, 8, 1, 4 };
HeapSort(data);
Console.WriteLine(string.Join(" ", data));
