# 0518 — Multiple arguments

Uses the CsCheck property-testing library to check a property over TWO generated integer arguments. `Gen.Int.Select(Gen.Int)` combines two integer generators into a generator of `(a, b)` tuples; `Sample` then draws ~100 pairs and verifies `max(a, b) >= a && max(a, b) >= b`. Because the property is universally true, `Sample` never throws and the program prints `passed`.

## Run

    dotnet run
