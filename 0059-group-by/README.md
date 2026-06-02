# 0059 — Group By

Group the words `one`, `two`, `three` by their length and print each length with its words, in ascending order of length: `3:[one,two] 5:[three]`. LINQ's `GroupBy(w => w.Length)` forms the groups and `OrderBy(g => g.Key)` sorts them; each `IGrouping` is then joined for output.

## Run

    dotnet run
