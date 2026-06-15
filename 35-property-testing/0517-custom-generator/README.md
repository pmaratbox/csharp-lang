# 0517 — Custom generator

This lesson uses **CsCheck**, a real property-based testing library for C#, run
programmatically rather than through a test runner. A *custom generator* is
built with the `.Select` combinator (a map): starting from `Gen.Int` we map
`n -> n * 2` to obtain a generator of even integers. `Sample(predicate, iter:)`
draws ~100 values from it and checks the property — every generated value is
even. A true property never throws, so the program prints `passed`.

## Run

    dotnet run
