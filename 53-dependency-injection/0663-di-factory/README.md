# 0663 — Factory provider

Uses [Microsoft.Extensions.DependencyInjection](https://learn.microsoft.com/dotnet/core/extensions/dependency-injection) and registers `Widget` through a **factory function** (`AddSingleton<Widget>(sp => new Widget("built"))`) rather than plain constructor autowiring. When we resolve `Widget` from the provider, the container runs the lambda to build the instance, and its `Value()` returns `built`.

## Run

    dotnet run
