int Gcd(int a, int b)
{
    while (b != 0)
    {
        (a, b) = (b, a % b);
    }
    return a;
}

Console.WriteLine(Gcd(48, 36));
