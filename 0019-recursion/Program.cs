long Factorial(long n)
{
    if (n <= 1)
    {
        return 1;
    }
    return n * Factorial(n - 1);
}

Console.WriteLine($"factorial(5) = {Factorial(5)}");
