// CsCheck — Sample(predicate) generates inputs and throws CsCheckException on
// failure (no stdout noise). NO seed needed: a true property always passes.
using CsCheck;

// Property: addition is commutative (a + b == b + a) for generated integers.
Gen.Int.Select(Gen.Int).Sample(t =>
{
    var (a, b) = t;
    return a + b == b + a;
}, iter: 100);

Console.WriteLine("passed");
