# 0032 — Math Functions

Take the square root of `16`, raise `2` to the 10th power, the absolute value of `-5`, and the larger of `3` and `9`, printing `sqrt: 4`, `pow: 1024`, `abs: 5`, and `max: 9`. `System.Math` holds the static helpers: `Sqrt` and `Pow` return `double` (cast to `int`), and `Abs`/`Max` have integer overloads. `Math.Pow` is always floating-point — `BigInteger.Pow` gives an exact integer power.

## Run

    dotnet run
