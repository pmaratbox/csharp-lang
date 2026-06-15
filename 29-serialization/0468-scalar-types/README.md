# 0468 — Scalar types

Serialize a record with `active:bool`, `count:int`, and `label:string` fields (declared alphabetically) to compact JSON using the built-in `System.Text.Json` library. `JsonSerializer.Serialize` with `JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }` emits each scalar with its native JSON representation, including a lowercase `true` for the boolean.

## Run

    dotnet run
