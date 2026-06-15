# 0538 — Sequence

Using the `Sprache` parser-combinator library, build a SEQUENCE parser that
runs `Parse.Char('a')` THEN `Parse.Char('b')`. Sprache expresses sequencing
through LINQ query syntax — each `from x in parser` consumes the next part of
the input in order, and the final `select` combines the two characters into the
string `ab`. Running it on the fixed input `"ab"` prints `ab`.

## Run

    dotnet run
