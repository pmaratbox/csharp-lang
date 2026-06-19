# 0665 — Big integer addition

This program uses `System.Numerics.BigInteger`, C#'s arbitrary-precision
integer type, to add two huge values (`12345678901234567890` and
`98765432109876543210`). Unlike `long`, `BigInteger` grows to hold any number
of digits, so the sum is computed exactly with no overflow.

## Run

    dotnet run
