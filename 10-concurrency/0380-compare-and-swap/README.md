# 0380 — Compare-And-Swap Loop

Increment a shared value to 100 using a CAS retry loop from multiple threads, printing `100`. C# uses `Interlocked.CompareExchange` in a retry loop to guard each increment.

## Run

    dotnet run
