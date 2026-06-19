# 0668 — Factorial

Compute 30! exactly using `System.Numerics.BigInteger`, C#'s arbitrary-precision
integer type. The result (265252859812191058636308480000000) far exceeds the range
of `long` or `ulong`, but `BigInteger` grows as needed, so multiplying the running
product by each `i` from 1 to 30 yields the exact value with no overflow or rounding.

## Run

    dotnet run
