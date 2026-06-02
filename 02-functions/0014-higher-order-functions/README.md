# 0014 — Higher-Order Functions

Write `apply(f, x)` that calls the function `f` on `x`, then pass it two
different functions, `inc` and `double`. C# models functions as the generic
delegate `Func<int, int>` (an `int -> int`), and a local function like
`int Inc(int x) => x + 1` is itself a first-class value that converts to that
delegate when passed as an argument. With top-level statements the code runs
straight from the file, with the local function declarations sitting alongside
the statements.

## Run

    dotnet run
