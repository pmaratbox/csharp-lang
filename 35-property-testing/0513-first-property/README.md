# 0513 — First property

This lesson uses **CsCheck**, a real property-based testing library for C#, run
programmatically rather than through a test runner. `Gen.Int.Array` is a
generator that produces random integer lists, and `Sample(predicate, iter:)`
draws ~100 of them and checks the property — reversing a list twice yields the
original. A true property never throws, so the program prints `passed`.

## Run

    dotnet run
