# 0087 — Invert a Map

Invert the map `{a: 1, b: 2, c: 3}` (swap keys and values) and print the result sorted by the new key: `1:a 2:b 3:c`. `ToDictionary(kv => kv.Value, kv => kv.Key)` builds the swapped map; `OrderBy` sorts it by the new key.

## Run

    dotnet run
