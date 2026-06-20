# 0702 — Removed line content

Uses the DiffPlex diff library to diff line-list `A=[apple, banana, cherry]` against `B=[apple, blueberry, cherry, date]`. `InlineDiffBuilder.Diff(a, b)` produces a line model where each entry carries a `ChangeType`; the lines marked `ChangeType.Deleted` are the ones removed from `A`. Collecting those texts in document (A) order and comma-joining them yields the removed line content `banana`.

## Run

    dotnet run
