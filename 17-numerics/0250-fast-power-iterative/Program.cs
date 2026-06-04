static long FastPow(long baseValue, long exp)
{
    long result = 1;
    while (exp > 0)
    {
        if ((exp & 1) == 1) result *= baseValue;
        baseValue *= baseValue;
        exp >>= 1;
    }
    return result;
}

Console.WriteLine(FastPow(2, 10));
