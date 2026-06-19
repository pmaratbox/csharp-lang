# 0658 — Inject a dependency

Uses [Microsoft.Extensions.DependencyInjection](https://learn.microsoft.com/dotnet/core/extensions/dependency-injection) to register a two-level service graph: `IRepo` (a singleton) and `Service` (a transient) whose constructor depends on `IRepo`. The container resolves `Service`, injecting the `Repo` instance automatically; calling `Run()` delegates to `repo.Data()`, which returns `data`.

## Run

    dotnet run
