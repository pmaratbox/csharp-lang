# 0667 — Big integer power

This lesson uses C#'s arbitrary-precision integer type `System.Numerics.BigInteger`
to compute `2` raised to the `100`th power exactly via `BigInteger.Pow(2, 100)`.
The result has 31 digits — far beyond any fixed-width integer — yet is exact (no
overflow, no float rounding).

## Run

    dotnet run
