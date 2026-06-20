# 0700 — Count removed lines

Diff `A=[apple, banana, cherry]` against `B=[apple, blueberry, cherry, date]` with the real **DiffPlex** library (`InlineDiffBuilder.Diff`), then count the lines whose `ChangeType` is `Deleted` — i.e. the lines present in A but removed in B (`banana`). The result is the number of removed lines: `1`.

## Run

    dotnet run
