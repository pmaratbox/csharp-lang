# 0670 — Exact decimal multiplication

This lesson multiplies `1.1 * 1.1` using C#'s built-in `decimal` type, a 128-bit base-10 exact-decimal type. Because `decimal` stores values in base 10 rather than binary floating point, the product is exactly `1.21` with no rounding error. The result is printed with `CultureInfo.InvariantCulture` so the decimal separator is always a dot.

## Run

    dotnet run
