# 0576 — CSV header row

Uses the CsvHelper library to parse the fixed CSV text `name,age,city\nAlice,30,Paris\n...`. The reader reads the first (header) row, and its fields are collected with `GetField` and joined with a pipe to print `name|age|city`.

## Run

    dotnet run
