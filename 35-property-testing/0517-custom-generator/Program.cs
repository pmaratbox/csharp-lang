// CsCheck — a custom generator is built with the .Select combinator (map):
// starting from Gen.Int we map n -> n * 2 to produce only even integers.
// Sample(predicate) draws ~100 values and throws CsCheckException on failure
// (no stdout noise). NO seed needed: every generated value is even, so the
// property is universally true and always passes.
using CsCheck;

var evens = Gen.Int.Select(n => n * 2);

evens.Sample(n => n % 2 == 0, iter: 100);

Console.WriteLine("passed");
