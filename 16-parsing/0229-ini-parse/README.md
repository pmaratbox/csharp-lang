# 0229 — Parse INI

Parse the INI text with section [s] and key k=v, printing the flattened entry `s.k=v`. The loop tracks the current section and emits `section.key=value` using range indexing.

## Run

    dotnet run
