# 0699 — Count added lines

Uses the DiffPlex diff library (`InlineDiffBuilder.Diff`) to compute the line-level diff between `A=[apple, banana, cherry]` and `B=[apple, blueberry, cherry, date]`. Each result line carries a `ChangeType`; counting the `ChangeType.Inserted` lines gives the number of ADDED lines, which is the deterministic `2`.

## Run

    dotnet run
