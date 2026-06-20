# 0705 — Identical inputs

Uses the [DiffPlex](https://www.nuget.org/packages/DiffPlex) diff library to
compare a fixed line-list `A` against itself (`A -> A`). `InlineDiffBuilder.Diff`
classifies every line as `Inserted`, `Deleted`, or `Unchanged`; since the two
inputs are identical the longest-common-subsequence covers all lines, so the
computed counts of added and removed lines are both zero. The program prints
`<added> <removed>`.

## Run

    dotnet run
