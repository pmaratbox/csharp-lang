# 0633 — Read a value

Uses the [Microsoft.Extensions.Configuration](https://learn.microsoft.com/dotnet/core/extensions/configuration) library to load `config.json` through a `ConfigurationBuilder` (with `SetBasePath` pointed at the working directory so the file is found outside `bin/`) and read the top-level string key `name`, which resolves to `myapp`.

## Run

    dotnet run
