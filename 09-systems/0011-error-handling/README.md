# 0011 — Error Handling

Write a `Divide(a, b)` that throws on a zero divisor, then call it on `10 / 2`
(prints the result) and `10 / 0` (prints an error). C# uses **exceptions**:
`throw` raises one (here the built-in `DivideByZeroException`), `try` / `catch`
handles a matching type, and `.Message` returns the text passed to the
constructor.

## Run

    dotnet run
