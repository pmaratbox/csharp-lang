# 0572 — TOML table

Uses the Tomlyn library to parse the TOML document `[server]\nhost = "localhost"\nport = 8080\n` with `Toml.ToModel`. The `[server]` section becomes a `TomlTable`, from which the `host` string and `port` integer are read and printed as `host=localhost port=8080`.

## Run

    dotnet run
