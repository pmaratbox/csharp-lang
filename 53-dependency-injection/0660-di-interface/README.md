# 0660 — Bind interface to impl

Uses [Microsoft.Extensions.DependencyInjection](https://github.com/dotnet/runtime) to bind the `IAnimal` abstraction to a `Dog` implementation in a `ServiceCollection`. After `BuildServiceProvider()`, the container resolves the service by its interface via `GetRequiredService<IAnimal>()`, and the resolved `Dog`'s `Sound()` method returns `woof`.

## Run

    dotnet run
