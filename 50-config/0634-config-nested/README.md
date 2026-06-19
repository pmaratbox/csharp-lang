# 0634 — Nested key

Uses Microsoft.Extensions.Configuration to load `config.json` and read the nested key `server.port` as an integer. Nested keys are addressed with a colon separator (`server:port`), and `GetValue<int>` binds the value to an `int`.

## Run

    dotnet run
