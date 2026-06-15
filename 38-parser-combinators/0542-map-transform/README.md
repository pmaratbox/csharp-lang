# 0542 — Map / transform

Using the `Sprache` parser-combinator library, build a parser from
`Parse.Number` and then transform its result with the `.Select` combinator
(the map operation). The number parser consumes the digits `21`, `int.Parse`
turns them into the integer `21`, and a second `.Select(n => n * 2)` maps that
value to `42`. The transformation happens entirely inside the parser pipeline,
so running it on the fixed input `"21"` prints `42`.

## Run

    dotnet run
