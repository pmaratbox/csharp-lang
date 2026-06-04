bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; (long)i * i <= n; i++)
    {
        if (n % i == 0) return false;
    }
    return true;
}

Console.WriteLine($"{(IsPrime(7) ? "yes" : "no")} {(IsPrime(9) ? "yes" : "no")}");
