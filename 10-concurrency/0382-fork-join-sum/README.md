# 0382 — Fork-Join Sum

Recursively fork the sum of [1..8] into halves and join the partial sums, printing `36`. C# forks each half with `Task.Run` and joins via `await Task.WhenAll`.

## Run

    dotnet run
