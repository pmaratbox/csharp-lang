// CsCheck — Gen.Int.Array generates integer lists; Sample(predicate) checks the
// property over ~100 generated inputs and throws CsCheckException on failure
// (no stdout noise). NO seed needed: this property is universally true.
using CsCheck;

Gen.Int.Array.Sample(xs =>
{
    var once = (int[])xs.Clone();
    Array.Sort(once);
    var twice = (int[])once.Clone();
    Array.Sort(twice);
    return twice.SequenceEqual(once);
}, iter: 100);

Console.WriteLine("passed");
