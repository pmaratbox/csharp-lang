# 0469 — Positional argument

Define a CLI with one positional argument `name` using the `CommandLineParser` library. The `[Value(0)]` attribute binds the first positional token to the `Name` property. For determinism the program parses a fixed argv `["alice"]` rather than the real process args, so `Parser.Default.ParseArguments` always yields the same result and `WithParsed` prints `alice`.

## Run

    dotnet run
