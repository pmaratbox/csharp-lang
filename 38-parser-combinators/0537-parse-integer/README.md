# 0537 — Parse an integer

Uses the [Sprache](https://github.com/sprache/Sprache) parser-combinator library. The parser is built from `Parse.Digit.AtLeastOnce()`, the combinator that matches one-or-more digit characters, then `.Select(...)` maps the captured run of digits into an `int`. Running `integer.Parse("42")` on the fixed input yields `42`.

## Run

    dotnet run
