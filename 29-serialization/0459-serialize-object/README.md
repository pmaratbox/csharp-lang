# 0459 — Serialize an object

Serialize a typed `Person(Age, Name)` record to a compact JSON string. Uses the built-in `System.Text.Json` library: `JsonSerializer.Serialize` with `JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }` so PascalCase properties become camelCase keys. Properties are declared alphabetically (`Age`, `Name`), which matches the canonical compact, alphabetically-keyed output.

## Run

    dotnet run
