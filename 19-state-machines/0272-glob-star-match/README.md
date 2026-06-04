# 0272 — Glob Star Match

Match the glob "a*b" (* = any run) against "aaab" (yes) and "aac" (no), printing `yes no`. Backtracking on the last `*` position implements greedy-with-fallback matching.

## Run

    dotnet run
