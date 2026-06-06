# 0405 — Map Operator

Implement a map operator that transforms each emitted value, applying x => x*2 to a stream of 1, 2, 3, 4. In C#, the operator wraps the source's Subscribe so each pushed value flows through f via a small closure.

## Run

    dotnet run
