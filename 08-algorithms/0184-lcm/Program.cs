int Gcd(int a, int b)
{
    while (b != 0)
    {
        (a, b) = (b, a % b);
    }
    return a;
}

int Lcm(int a, int b) => a / Gcd(a, b) * b;

Console.WriteLine(Lcm(4, 6));
