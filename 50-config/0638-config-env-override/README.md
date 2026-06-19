# 0638 — Env override

Uses the [Microsoft.Extensions.Configuration](https://learn.microsoft.com/dotnet/core/extensions/configuration) library to load `config.json` (where `name` is `myapp`) and then layer an in-process environment variable on top via `AddEnvironmentVariables`. Because the environment-variables source is added last, it has higher priority and overrides `name` to `from-env`, which is what gets printed.

## Run

    dotnet run
