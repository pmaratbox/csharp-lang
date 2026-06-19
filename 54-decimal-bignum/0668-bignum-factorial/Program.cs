using System.Numerics;

// Compute 30! exactly with System.Numerics.BigInteger (arbitrary precision).
BigInteger f = BigInteger.One;
for (int i = 1; i <= 30; i++)
{
    f *= i;
}

Console.WriteLine(f);
