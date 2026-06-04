# 0110 — Currying

Curry a two-argument add into a chain of one-argument functions and call it as `add(2)(3)`, printing `5`. In C# the curried form is a `Func<int, Func<int, int>>` whose outer lambda captures the first argument in a closure.

## Run

    dotnet run
