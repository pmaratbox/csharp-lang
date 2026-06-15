# 0463 — Array of primitives

Serialize a list of integers to a compact JSON array. This lesson uses the built-in `System.Text.Json` library: `JsonSerializer.Serialize` turns the `List<int> { 1, 2, 3 }` directly into the JSON array `[1,2,3]` with no extra whitespace.

## Run

    dotnet run
