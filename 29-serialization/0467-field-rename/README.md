# 0467 — Field Rename

Uses the built-in `System.Text.Json` library. The `[JsonPropertyName("full_name")]` attribute renames the record's `FullName` property so it serializes to the JSON key `full_name`, overriding the default camelCase naming policy.

## Run

    dotnet run
