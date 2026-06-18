# 0571 — TOML scalars

Uses the `Tomlyn` library to parse the fixed TOML document `title = "demo"\nversion = 2\n`. `Toml.ToModel(...)` returns a `TomlTable` whose `title` key is the string `demo` and whose `version` key is the integer `2`. The two values are printed space-joined as `demo 2`.

## Run

    dotnet run
