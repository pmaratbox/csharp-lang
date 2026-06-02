# 0037 — Operator Overloading

Define how `+` (or an `add` method) combines two points, then add `(1, 2)` and `(3, 4)` and print `(4, 6)`. A `public static Point operator +` overloads `+` for the type. C# allows overloading most operators as static members; the positional `record` provides the properties and a deconstructor.

## Run

    dotnet run
