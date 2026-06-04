# 0104 — Atomic Counter

Increment a shared atomic counter from multiple threads 1000 times total without a lock, printing `1000`. `Interlocked.Increment` performs a lock-free atomic add on the shared field.

## Run

    dotnet run
