# 0657 — Resolve a service

Uses [Microsoft.Extensions.DependencyInjection](https://github.com/dotnet/runtime) to register an `IGreeter` service (implemented by `Greeter`) in a `ServiceCollection`. After `BuildServiceProvider()`, the container resolves the service via `GetRequiredService<IGreeter>()` and its `Greet()` method returns `hello`.

## Run

    dotnet run
