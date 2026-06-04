# 0107 — Worker Pool

Distribute squaring of 1..4 across a pool of workers, collect the results, and print them sorted ascending `1 4 9 16`. Each square runs as a thread-pool `Task`, then `Task.WhenAll` gathers the results which are sorted before printing.

## Run

    dotnet run
