# 0020 — Pattern Matching

Match `n` against the literal patterns `1` and `2` with a wildcard fallback, mapping `1`, `2`, and `5` to `one`, `two`, and `many`. This is a `switch` *expression* (C# 8+): `n switch { 1 => ..., _ => ... }` yields a value, with `_` as the discard/wildcard arm. C#'s pattern matching also supports type, relational (`> 0`), and property patterns.

## Run

    dotnet run
