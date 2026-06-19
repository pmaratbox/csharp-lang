# 0688 — Group by

This program uses [LINQ](https://learn.microsoft.com/dotnet/csharp/linq/),
C#'s standard functional/collection library, and its `Enumerable.GroupBy`
transform to group the list `[1, 2, 3, 4, 5, 6]` by parity (`even`/`odd`). The
groups are sorted by key with `OrderBy`, then each is formatted as
`key:v1,v2,...` and joined with `;` via `string.Join`, so the grouping comes
from the library's own `GroupBy` rather than being hardcoded.

## Run

    dotnet run
