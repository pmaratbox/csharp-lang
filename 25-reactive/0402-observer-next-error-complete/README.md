# 0402 — Observer Contract

Demonstrate the observer contract next*-then-terminal: emit 1 and 2, complete, and show that a post-complete next is ignored. A `_stopped` bool flag, set on the first terminal, makes later `Next`/terminal calls no-ops.

## Run

    dotnet run
