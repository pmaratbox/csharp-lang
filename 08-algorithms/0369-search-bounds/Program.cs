int[] a = [1, 3, 5, 5, 7];
const int target = 5;

int LowerBound(int[] xs, int value)
{
    int lo = 0, hi = xs.Length;
    while (lo < hi)
    {
        int mid = lo + (hi - lo) / 2;
        if (xs[mid] < value) lo = mid + 1;
        else hi = mid;
    }
    return lo;
}

int UpperBound(int[] xs, int value)
{
    int lo = 0, hi = xs.Length;
    while (lo < hi)
    {
        int mid = lo + (hi - lo) / 2;
        if (xs[mid] <= value) lo = mid + 1;
        else hi = mid;
    }
    return lo;
}

Console.WriteLine($"{LowerBound(a, target)} {UpperBound(a, target)}");
