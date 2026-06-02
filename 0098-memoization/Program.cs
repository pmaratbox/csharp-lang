var cache = new Dictionary<int, int>();

int Fib(int n)
{
    if (n < 2) return n;
    if (cache.TryGetValue(n, out int v)) return v;
    int result = Fib(n - 1) + Fib(n - 2);
    cache[n] = result;
    return result;
}

Console.WriteLine(Fib(10));
