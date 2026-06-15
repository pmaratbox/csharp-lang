# 0461 — Nested object

Serialize a record that contains another record. This lesson uses the built-in `System.Text.Json` library: `JsonSerializer.Serialize` walks the nested `Person`/`Address` records and, with `JsonNamingPolicy.CamelCase`, emits compact JSON whose nested object keys are produced in alphabetical declaration order.

## Run

    dotnet run
