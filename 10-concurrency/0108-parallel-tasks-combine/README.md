# 0108 — Parallel Tasks Combined

Run two independent tasks that produce 10 and 20 concurrently, then combine (sum) their results into `30`. `Task.Run` starts each on the thread pool and `await Task.WhenAll` joins both `Task<int>` results.

## Run

    dotnet run
