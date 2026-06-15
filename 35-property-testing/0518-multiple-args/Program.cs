// CsCheck — a property over TWO generated integer arguments via Gen.Int.Select((a, b) => ...).
// Sample(predicate) generates ~100 (a, b) pairs and throws CsCheckException on failure.
// NO seed needed: this property is universally true, so it always passes.
using CsCheck;

Gen.Int.Select(Gen.Int).Sample(t =>
{
    var (a, b) = t;
    var m = Math.Max(a, b);
    return m >= a && m >= b;
}, iter: 100);

Console.WriteLine("passed");
