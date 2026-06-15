# 0473 — Multiple values

Collect a repeated option into a list. Uses the `CommandLineParser` library: an `[Option("num")]` declared as `IEnumerable<int>` accumulates values into a sequence, and `GetoptMode` lets the same `--num` flag repeat. The parser runs on a fixed, hardcoded argv (`--num 1 --num 2 --num 3`) instead of the real process arguments, so the output is deterministic. The collected values are summed and printed -> 6.

## Run

    dotnet run
