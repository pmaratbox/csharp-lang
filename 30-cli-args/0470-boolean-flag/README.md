# 0470 — Boolean flag

Parse a boolean flag with the `CommandLineParser` library (`using CommandLine;`). The `Options` class declares a `[Option("verbose")]` property of type `bool`, which the parser treats as a switch that is `true` when `--verbose` is present. For determinism the program parses a fixed, hardcoded argv `["--verbose"]` instead of the real process arguments, then prints the flag value as lowercase `true`.

## Run

    dotnet run
