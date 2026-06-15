# 0474 — Subcommand

Dispatch to a subcommand using the `CommandLineParser` library. Each subcommand is its own options class tagged with `[Verb("add")]` / `[Verb("sub")]`, and the two `[Value(...)]` integer positionals capture the operands. `ParseArguments<AddOptions, SubOptions>` reads the leading token as the verb name and dispatches to the matching type, so the typed `WithParsed<AddOptions>` handler runs only for `add`. For determinism the program parses a fixed argv `["add", "2", "3"]` rather than the real process args, so it always dispatches to `add`, sums the values, and prints `5`.

## Run

    dotnet run
