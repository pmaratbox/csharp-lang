# 0519 — Precondition / filter

Uses CsCheck's `Gen.Int.Where(...)` precondition combinator to filter generated integers down to positive values, then `Sample(predicate, iter: 100)` to check the property programmatically (no test runner): for every positive `n`, `n + 1 > n`. The `Where` filter is the library's `filter`/`assume`/`suchThat` equivalent, so non-positive inputs never reach the predicate. Under this precondition the property is universally true, so `Sample` never throws `CsCheckException` and `passed` is printed.

## Run

    dotnet run
