# 0573 — TOML array

Uses the Tomlyn library to parse the TOML document `tags = ["red", "green", "blue"]\n` via `Toml.ToModel`. The `tags` key is read back as a `TomlArray` of strings, which are then joined with commas to print `red,green,blue`.

## Run

    dotnet run
