// CsCheck — a precondition narrows the generator before the property runs.
// Gen.Int.Where(n => n > 0) filters generated integers so only POSITIVE values
// reach the predicate; Sample(predicate, iter: 100) then checks n + 1 > n over
// ~100 generated inputs and throws CsCheckException on failure (no stdout noise).
// NO seed needed: under the precondition the property is universally true.
using CsCheck;

Gen.Int.Where(n => n > 0).Sample(n => n + 1 > n, iter: 100);

Console.WriteLine("passed");
