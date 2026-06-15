# 0544 — Expression

Using the `Sprache` parser-combinator library, build a parser for a
`'+'`-separated sequence of integers and evaluate it. A `number` parser
(`Parse.Number.Select(int.Parse)`) is combined with `.DelimitedBy(Parse.Char('+'))`
(the sepBy combinator) to recognize `10+20+30`, and `.Select(values => values.Sum())`
folds the parsed integers into their sum. Running the parser on the fixed input
`10+20+30` prints `60`.

## Run

    dotnet run
