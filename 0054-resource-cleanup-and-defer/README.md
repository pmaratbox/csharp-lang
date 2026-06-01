# 0054 — Resource Cleanup & Defer

Acquire a resource, use it, and let the language release it automatically at scope exit, printing `open`, `use`, and `close` in that order. A `using` statement calls `Dispose()` on the `IDisposable` when the block exits — the framework's deterministic cleanup, equivalent to a `try`/`finally`.

## Run

    dotnet run
