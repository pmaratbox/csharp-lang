# 0669 — Exact decimal addition

C#'s built-in `decimal` is a 128-bit base-10 floating-point type, so it represents `0.1` and `0.2` exactly and their sum is precisely `0.3` — unlike binary `double`, which yields `0.30000000000000004`. We add the two `decimal` literals and print the result with `CultureInfo.InvariantCulture` (the machine locale would otherwise use a comma decimal separator).

## Run

    dotnet run
