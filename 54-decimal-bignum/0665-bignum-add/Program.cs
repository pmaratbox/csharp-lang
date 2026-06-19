using System.Numerics;

// System.Numerics.BigInteger holds integers of arbitrary size, so adding two
// 20-digit numbers yields an exact result with no overflow.
BigInteger a = BigInteger.Parse("12345678901234567890");
BigInteger b = BigInteger.Parse("98765432109876543210");
Console.WriteLine(a + b);
