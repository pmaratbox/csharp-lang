# 0472 — Default value

Define an integer option `--count` whose default value is `1`. Uses the CommandLineParser library: the `[Option("count", Default = 1)]` attribute supplies the fallback used when the flag is absent. It parses a fixed, hardcoded empty argv (`[]`) rather than the real process arguments, so the program is deterministic — with no `--count` supplied, the parser fills in the default and prints `1`.

## Run

    dotnet run
