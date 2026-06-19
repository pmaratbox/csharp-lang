# 0639 — Integer value

Uses the [Microsoft.Extensions.Configuration](https://learn.microsoft.com/dotnet/core/extensions/configuration) library to load `config.json` through a `ConfigurationBuilder` (with `SetBasePath` pointed at the working directory so the file is found outside `bin/`) and read the integer key `retries` via `GetValue<int>`, which resolves to `3`.

## Run

    dotnet run
