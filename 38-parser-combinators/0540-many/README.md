# 0540 — Many (repetition)

Using the `Sprache` parser-combinator library, the `.Many()` combinator
applies a parser zero-or-more times, collecting each successful match into a
sequence. Here `Parse.Char('a').Many()` is run on the fixed input `aaaa`,
and counting the collected matches prints `4`.

## Run

    dotnet run
