int n = 60;
List<int> factors = [];

while (n % 2 == 0)
{
    factors.Add(2);
    n /= 2;
}

for (int i = 3; (long)i * i <= n; i += 2)
{
    while (n % i == 0)
    {
        factors.Add(i);
        n /= i;
    }
}

if (n > 1)
{
    factors.Add(n);
}

Console.WriteLine(string.Join(' ', factors));
