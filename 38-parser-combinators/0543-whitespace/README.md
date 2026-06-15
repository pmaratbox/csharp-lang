# 0543 — Whitespace handling

Uses the [Sprache](https://github.com/sprache/Sprache) parser-combinator library. The `.Token()` combinator wraps an inner parser so it consumes optional leading and trailing whitespace (built on `Parse.WhiteSpace`). Here `Parse.Number.Select(int.Parse).Token()` parses an integer surrounded by spaces, so running it on the fixed input `"  42  "` yields `42`.

## Run

    dotnet run
