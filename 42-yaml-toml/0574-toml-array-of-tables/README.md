# 0574 — TOML array of tables

Uses the Tomlyn library to parse a TOML document containing an array of tables (`[[servers]]`). `Toml.ToModel(...)` returns a model where `model["servers"]` is a `Tomlyn.Model.TomlTableArray`. The program collects each table's `name` value and joins them with commas, producing `alpha,beta`.

## Run

    dotnet run
