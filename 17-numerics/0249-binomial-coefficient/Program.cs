static long Binomial(int n, int k)
{
    if (k > n - k) k = n - k;
    long result = 1;
    for (int i = 0; i < k; i++)
    {
        result *= n - i;
        result /= i + 1;
    }
    return result;
}

Console.WriteLine(Binomial(5, 2));
