# 0701 — Added line content

Uses the `DiffPlex` library to diff two fixed line-lists `A=[apple,banana,cherry]` and `B=[apple,blueberry,cherry,date]`. `InlineDiffBuilder.Diff(a, b)` produces a model whose `Lines` are classified by `ChangeType`; the lines marked `ChangeType.Inserted` are the additions. Printed in document (B) order and comma-joined, the added lines are `blueberry,date`.

## Run

    dotnet run
