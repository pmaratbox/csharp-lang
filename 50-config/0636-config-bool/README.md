# 0636 — Boolean value

Uses the [Microsoft.Extensions.Configuration](https://learn.microsoft.com/dotnet/core/extensions/configuration) library to load `config.json` through a `ConfigurationBuilder` (with `SetBasePath` pointed at the working directory) and read the boolean key `debug` via `GetValue<bool>`, printing it lowercase as `true`.

## Run

    dotnet run
