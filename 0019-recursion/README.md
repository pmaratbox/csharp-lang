# 0019 — Recursion

Define a recursive `factorial(n)` that multiplies `n` by `factorial(n - 1)` until it bottoms out at `1`, then print `factorial(5) = 120`. A local function declared inside the top-level statements can call itself recursively. The CLR does not guarantee tail-call optimization, so depth is bounded by the stack; `long` (64-bit) is used because `factorial` overflows a 32-bit `int` quickly.

## Run

    dotnet run
