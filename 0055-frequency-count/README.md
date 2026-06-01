# 0055 — Frequency Count

Count how many times each letter appears in `banana` and print the per-letter counts in alphabetical order: `a:3 b:1 n:2`. `SortedDictionary<char, int>` keeps keys ordered; `GetValueOrDefault(ch, 0)` reads a missing count as zero, and LINQ's `Select` formats each pair.

## Run

    dotnet run
