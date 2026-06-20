# 0704 — Diff summary

Uses the `DiffPlex` library to diff two fixed line-lists `A=[apple,banana,cherry]` and `B=[apple,blueberry,cherry,date]`. `InlineDiffBuilder.Diff(a, b)` produces a model whose `Lines` are classified by `ChangeType`; counting `Inserted`, `Deleted`, and `Unchanged` gives the added, removed, and unchanged totals. Space-joined, the summary is `2 1 2`.

## Run

    dotnet run
