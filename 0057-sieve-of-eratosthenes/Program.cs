int n = 10;
var isPrime = new bool[n + 1];
Array.Fill(isPrime, true);
isPrime[0] = isPrime[1] = false;
for (int i = 2; i * i <= n; i++)
{
    if (isPrime[i])
    {
        for (int j = i * i; j <= n; j += i)
        {
            isPrime[j] = false;
        }
    }
}

var primes = new List<string>();
for (int i = 2; i <= n; i++)
{
    if (isPrime[i]) primes.Add(i.ToString());
}
Console.WriteLine(string.Join(" ", primes));
