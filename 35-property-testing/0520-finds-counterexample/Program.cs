// CsCheck — a densely FALSE property is always caught, with NO seed.
// Property under test: "every non-negative integer is < 100". This is false for
// any generated value >= 100, so Sample(predicate, iter: ...) reliably finds a
// counterexample and throws CsCheckException. We catch the exception to detect
// the failure programmatically (no test runner) and print "found".
// Console.Out is redirected to a discarding writer for the duration of Sample so
// the library's falsifying-example / shrink report never leaks to stdout; the
// real stdout is restored before printing, so ONLY "found" is emitted.
using CsCheck;

var real = Console.Out;
bool found = false;
Console.SetOut(TextWriter.Null);
try
{
    Gen.Int[0, int.MaxValue].Sample(n => n < 100, iter: 100000);
}
catch (CsCheckException)
{
    found = true;
}
finally
{
    Console.SetOut(real);
}

Console.WriteLine(found ? "found" : "no-ce");
