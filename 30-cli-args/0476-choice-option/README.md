# 0476 — Choice option

Restrict an option to a fixed set of choices using the **CommandLineParser** library. The `--color` option is bound to a `Color` enum (`Red`, `Green`, `Blue`), so the parser only accepts one of those names and rejects anything else — the library's idiomatic way to express a choice option. For determinism the program parses a fixed argv `["--color", "green"]` rather than the real process arguments, then prints the chosen value lowercased: `green`.

## Run

    dotnet run
