int[] a = [7, 10, 4, 3, 20, 15];
int k = 3; // 3rd smallest (1-based)

int Partition(int[] xs, int lo, int hi)
{
    int pivot = xs[hi];
    int i = lo;
    for (int j = lo; j < hi; j++)
        if (xs[j] < pivot)
        {
            (xs[i], xs[j]) = (xs[j], xs[i]);
            i++;
        }
    (xs[i], xs[hi]) = (xs[hi], xs[i]);
    return i;
}

int QuickSelect(int[] xs, int lo, int hi, int target)
{
    int p = Partition(xs, lo, hi);
    if (p == target) return xs[p];
    return p < target ? QuickSelect(xs, p + 1, hi, target)
                      : QuickSelect(xs, lo, p - 1, target);
}

Console.WriteLine(QuickSelect(a, 0, a.Length - 1, k - 1));
