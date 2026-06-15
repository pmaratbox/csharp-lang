# 0516 — Sort is idempotent

Uses CsCheck's `Gen.Int.Array` generator to produce ~100 random integer lists and `Sample(predicate, iter: 100)` to check the property programmatically (no test runner): sorting an already-sorted list equals sorting once, i.e. `sort(sort(xs)) == sort(xs)`. The property is universally true, so `Sample` never throws `CsCheckException` and `passed` is printed.

## Run

    dotnet run
