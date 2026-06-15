# 0520 — Finds a counterexample

Uses CsCheck's `Gen.Int[0, int.MaxValue]` bounded integer generator with `Sample(predicate, iter: ...)` to check a deliberately FALSE property — "every non-negative integer is `< 100`" — programmatically (no test runner). Because the property is densely false, CsCheck reliably generates and shrinks a counterexample and throws `CsCheckException`; catching that exception detects the failure and prints `found`. No seed is needed: the falsifying input is always discovered. The library's falsifying-example / shrink report is suppressed by redirecting `Console.Out` to `TextWriter.Null` for the duration of `Sample`, then restoring real stdout, so only `found` is printed.

## Run

    dotnet run
