# 0568 — Nested YAML mapping

Uses the `YamlDotNet` library to parse a YAML document with a nested mapping: `server:` containing `host: localhost` and `port: 8080`. The top-level document deserializes into a `Dictionary<string, object>`, and the `server` value is itself a nested `Dictionary<object, object>`. The lesson reads `server.host` and `server.port` and prints them joined with a colon as `localhost:8080`.

## Run

    dotnet run
