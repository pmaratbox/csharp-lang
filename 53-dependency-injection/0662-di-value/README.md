# 0662 — Inject a value

Uses [Microsoft.Extensions.DependencyInjection](https://github.com/dotnet/runtime) to register a constant `Config("v1")` value instance as a singleton in a `ServiceCollection`. After `BuildServiceProvider()`, the container resolves `Service` — injecting the registered `Config` into its constructor — and its `Read()` method returns the injected value `v1`.

## Run

    dotnet run
