# 0003 — Arithmetic & operators

Compute and print the five elementary arithmetic operations on two integers
(`a = 17`, `b = 5`). C#'s `/` between two `int`s truncates toward zero
(`17 / 5 → 3`); cast one operand with `(double)a / b` for the fractional
quotient. String interpolation (`$"…"`) is culture-sensitive, so
`string.Create(CultureInfo.InvariantCulture, $"…")` pins the decimal point to a
`.` (giving `3.4`) regardless of the host locale. Interpolation calls each
value's `ToString()`, so a `bool` would print `True`/`False` rather than the
lowercase form some other languages use.

## Run

    dotnet run
