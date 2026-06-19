using System.Numerics;

// System.Numerics.BigInteger multiplies arbitrarily large integers exactly,
// so 123456789 * 987654321 yields the full 18-digit product with no overflow.
BigInteger a = BigInteger.Parse("123456789");
BigInteger b = BigInteger.Parse("987654321");
Console.WriteLine(a * b);
