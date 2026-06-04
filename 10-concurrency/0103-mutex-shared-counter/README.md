# 0103 — Mutex-Protected Counter

Have multiple threads each increment a shared counter under a mutex so the total is exactly `1000`. A `lock` statement serializes each increment so no updates are lost.

## Run

    dotnet run
