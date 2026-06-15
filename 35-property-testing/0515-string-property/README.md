# 0515 — String property

This lesson uses the CsCheck property-testing library to check a property over randomly generated strings. The `Gen.String` generator produces sample strings, and `Sample(predicate, iter: 100)` runs the predicate against ~100 generated values, throwing a `CsCheckException` (with no stdout noise) only if a counterexample is found. The property asserts that the length of `s + s` equals `2 * s.Length` for every generated string `s`; since it holds universally the check passes and the program prints `passed`. No seed is needed.

## Run

    dotnet run
