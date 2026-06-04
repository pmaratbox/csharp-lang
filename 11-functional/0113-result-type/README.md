# 0113 — Result / Either Type

Model success and failure with a Result type: safeDiv(10,2) prints `ok: 5` and safeDiv(1,0) prints `err: divide by zero`. C# models the sum type as an abstract record with `Ok`/`Err` cases and pattern-matches them with a `switch` expression.

## Run

    dotnet run
