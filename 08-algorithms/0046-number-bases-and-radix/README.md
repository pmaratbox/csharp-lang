# 0046 — Number Bases & Radix

Print the integer `255` in hexadecimal, octal, and binary, producing `hex: ff`, `oct: 377`, and `bin: 11111111`. `Convert.ToString(n, toBase)` supports bases 2, 8, 10, and 16 only, covering all three here. Interpolation has format specifiers for hex (`{n:X}`) and, since .NET 8, binary (`{n:B}`), but none for octal.

## Run

    dotnet run
