# 0111 — Partial Application

Partially apply a two-argument add by fixing the first argument to 10, then call the result with 3 to print `13`. A C# lambda that captures the fixed argument and forwards the rest yields the partially applied `Func<int, int>`.

## Run

    dotnet run
