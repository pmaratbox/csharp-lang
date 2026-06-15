# 0471 — Option with value

Define a `--name` option that takes a string value using the `CommandLineParser` library (the `[Option]` attribute on an `Options` class). The parser reads a hardcoded argv array `["--name", "alice"]` rather than the real process arguments, so the program is deterministic and always prints the parsed value `alice`. `Parser.Default.ParseArguments<Options>(...).WithParsed(...)` binds the matched value to the `Name` property.

## Run

    dotnet run
