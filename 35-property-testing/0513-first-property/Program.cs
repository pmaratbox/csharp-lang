// CsCheck — Sample(predicate) generates inputs and throws CsCheckException on
// failure (no stdout noise). NO seed needed: this property is universally true,
// so it always passes. Gen.Int.Array produces random integer lists.
using CsCheck;

Gen.Int.Array.Sample(xs =>
{
    var r = (int[])xs.Clone();
    Array.Reverse(r);
    Array.Reverse(r);
    return r.SequenceEqual(xs);
}, iter: 100);

Console.WriteLine("passed");
