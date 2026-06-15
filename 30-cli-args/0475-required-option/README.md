# 0475 — Required option

Declare a CLI option as required using the CommandLineParser library. The `[Option("id", Required = true)]` attribute marks `--id` mandatory, so parsing fails if it is missing. For determinism we parse a fixed hardcoded argv `["--id", "42"]` instead of the real process arguments, so `Parser.Default.ParseArguments<Options>` always succeeds and prints `42`.

## Run

    dotnet run
