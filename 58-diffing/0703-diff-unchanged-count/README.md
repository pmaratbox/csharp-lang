# 0703 — Count unchanged lines

Diff `A=[apple,banana,cherry]` against `B=[apple,blueberry,cherry,date]` with the DiffPlex library (`InlineDiffBuilder.Diff`). Each result line carries a `ChangeType`; counting the lines whose type is `ChangeType.Unchanged` (`apple`, `cherry`) gives the number of UNCHANGED lines, which is `2`. The count is LCS-determined, so it does not depend on edit-script ordering.

## Run

    dotnet run
