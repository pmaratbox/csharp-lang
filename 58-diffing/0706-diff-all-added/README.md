# 0706 — All lines added

Uses the DiffPlex diff library (`InlineDiffBuilder.Diff`) to compute the line-level diff from an EMPTY list to `B=[x, y]`. Because the source is empty, every line in `B` is an addition; counting the `ChangeType.Inserted` lines gives the deterministic added count `2`.

## Run

    dotnet run
