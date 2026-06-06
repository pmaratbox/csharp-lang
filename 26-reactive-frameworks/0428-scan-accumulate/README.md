# 0428 — Scan (Running Fold)

Use the library's scan operator to emit the running sum of 1, 2, 3, 4. Uses System.Reactive (Rx.NET) `Scan(0, (acc, x) => acc + x)`, which does not re-emit the seed, so each running total flows through directly.

## Run

    dotnet run
