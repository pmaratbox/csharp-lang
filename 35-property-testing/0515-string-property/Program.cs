// CsCheck — Gen.String generates strings; Sample(predicate) throws CsCheckException
// on failure (no stdout noise). NO seed needed: this property is universally true.
using CsCheck;

// Property: the length of s+s equals 2*len(s) for generated strings s.
Gen.String.Sample(s => (s + s).Length == 2 * s.Length, iter: 100);

Console.WriteLine("passed");
