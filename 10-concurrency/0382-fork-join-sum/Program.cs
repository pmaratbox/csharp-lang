async Task<int> SumAsync(int lo, int hi)
{
    if (lo == hi) return lo;
    int mid = (lo + hi) / 2;
    Task<int> left = SumAsync(lo, mid);
    Task<int> right = SumAsync(mid + 1, hi);
    int[] parts = await Task.WhenAll(left, right);
    return parts[0] + parts[1];
}

Console.WriteLine(await SumAsync(1, 8));
