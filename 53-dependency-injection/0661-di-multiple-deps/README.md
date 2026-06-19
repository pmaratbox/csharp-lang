# 0661 — Multiple dependencies

Uses [Microsoft.Extensions.DependencyInjection](https://learn.microsoft.com/dotnet/core/extensions/dependency-injection) to register a service graph where `Service` depends on BOTH `IA` and `IB`. The container resolves `Service`, injecting the `A` and `B` singletons into its constructor; calling `Run()` returns `a.X() + b.Y()`, which prints `ab`.

## Run

    dotnet run
