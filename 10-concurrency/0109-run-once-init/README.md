# 0109 — Run-Once Initialization

Ensure an initializer runs exactly once even when several threads race to trigger it, printing `init count: 1`. `Lazy<T>` with `ExecutionAndPublication` guarantees the factory runs a single time despite concurrent access.

## Run

    dotnet run
