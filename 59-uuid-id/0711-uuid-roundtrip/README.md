# 0711 — Parse and format

This lesson uses the built-in **System.Guid** type to parse a UUID and print it
back in canonical form. `Guid.Parse` accepts the value case-insensitively, so the
uppercase input `550E8400-E29B-41D4-A716-446655440000` parses fine, and
`ToString()` emits the canonical lowercase, hyphenated representation
`550e8400-e29b-41d4-a716-446655440000`.

## Run

    dotnet run
