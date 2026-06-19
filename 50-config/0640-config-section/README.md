# 0640 — Read a section

Uses Microsoft.Extensions.Configuration to load `config.json` and read multiple keys from the `server` section. The nested keys `server:host` and `server:port` are read with the colon separator and combined into the `host:port` string `0.0.0.0:8080`.

## Run

    dotnet run
