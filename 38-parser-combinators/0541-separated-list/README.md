# 0541 — Separated list

Using the **Sprache** parser-combinator library, build an `integer` parser from
`Parse.Number` mapped with `.Select(int.Parse)`, then use the
`.DelimitedBy(Parse.Char(','))` combinator (Sprache's `sepBy`) to parse a
comma-separated list of integers. Running the parser on the fixed input
`"1,2,3"` yields the list `[1, 2, 3]`, whose sum is `6`.

## Run

    dotnet run
