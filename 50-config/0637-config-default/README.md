# 0637 — Default for missing key

Uses the [Microsoft.Extensions.Configuration](https://learn.microsoft.com/dotnet/core/extensions/configuration) library to load `config.json` through a `ConfigurationBuilder` (with `SetBasePath` pointed at the working directory so the file is found outside `bin/`). Reading the absent key `missing` returns `null`, so the C# null-coalescing operator (`??`) supplies the default value `fallback`.

## Run

    dotnet run
