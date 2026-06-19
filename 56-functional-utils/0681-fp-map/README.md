# 0681 — Map

This program uses [LINQ](https://learn.microsoft.com/dotnet/csharp/linq/),
C#'s standard functional/collection library, and its `Enumerable.Select`
transform to map `x -> x*2` over the list `[1, 2, 3]`. The doubled values are
comma-joined with `string.Join`, so the result comes from the library's own
`Select` projection rather than being hardcoded.

## Run

    dotnet run
