# 0413 — Zip Streams

Implement zip that pairs values by index and combines them; zip [1,2,3] with [10,20,30] using a+b. A per-source `Queue<T>` buffers emissions and the zip drains a pair whenever both queues are non-empty.

## Run

    dotnet run
