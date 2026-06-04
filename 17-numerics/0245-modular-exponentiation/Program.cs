static long ModPow(long b, long e, long m)
{
    long result = 1;
    b %= m;
    while (e > 0)
    {
        if ((e & 1) == 1) result = result * b % m;
        b = b * b % m;
        e >>= 1;
    }
    return result;
}

Console.WriteLine(ModPow(3, 13, 7));
