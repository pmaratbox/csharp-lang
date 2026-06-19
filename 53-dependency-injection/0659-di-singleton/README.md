# 0659 — Singleton lifetime

Uses the [Microsoft.Extensions.DependencyInjection](https://learn.microsoft.com/dotnet/core/extensions/dependency-injection) container. `IRepo` is registered with `AddSingleton<IRepo, Repo>()`, so the container creates a single shared instance. Resolving it twice from the same provider returns the very same object, and `ReferenceEquals` over the two resolutions prints `true`.

## Run

    dotnet run
