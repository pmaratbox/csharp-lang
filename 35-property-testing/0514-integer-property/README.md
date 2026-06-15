# 0514 — Integer property

This lesson uses the [CsCheck](https://www.nuget.org/packages/CsCheck)
property-based testing library run programmatically (not via a test runner).
`Gen.Int` generates random integers and `Gen.Int.Select(Gen.Int)` pairs two of
them into a tuple generator. `Sample(predicate, iter: 100)` evaluates the
property `a + b == b + a` over ~100 generated pairs; since the property always
holds it never throws, so the program prints `passed`.

## Run

    dotnet run
