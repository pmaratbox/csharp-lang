# 0682 — Filter

This lesson uses LINQ (the .NET standard query library, `System.Linq`) and its `Where` transform to keep only the elements of a sequence that satisfy a predicate. We filter the even numbers out of `[1..6]` with `Where(x => x % 2 == 0)` and comma-join the result.

## Run

    dotnet run
