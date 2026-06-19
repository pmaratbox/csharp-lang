# 0635 — List value

Uses the [Microsoft.Extensions.Configuration](https://learn.microsoft.com/dotnet/core/extensions/configuration) library to load `config.json` through a `ConfigurationBuilder` (with `SetBasePath` pointed at the working directory so the file is found outside `bin/`) and read the array key `hosts` via `GetSection("hosts").Get<string[]>()`, joining the elements with commas to produce `a,b,c`.

## Run

    dotnet run
