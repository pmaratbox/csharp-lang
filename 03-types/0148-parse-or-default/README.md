# 0148 — Parse or Default

Parse "42" to 42 and "x" (invalid) to a default 0, printing `42 0`. C# `int.TryParse` returns a `bool` and writes the result via an `out` parameter, so a failed parse cleanly falls back to a default.

## Run

    dotnet run
