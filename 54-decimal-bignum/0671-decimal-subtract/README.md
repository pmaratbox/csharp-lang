# 0671 — Exact decimal subtraction

This lesson subtracts `1.0 - 0.1` using C#'s built-in `decimal` type, a 128-bit base-10 exact-decimal type. Because `decimal` stores values in base 10 rather than binary floating point, the difference is exactly `0.9` with no rounding error. The result is printed with `CultureInfo.InvariantCulture` so the decimal separator is always a dot.

## Run

    dotnet run
