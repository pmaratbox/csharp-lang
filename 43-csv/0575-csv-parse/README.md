# 0575 — Parse CSV rows

Uses the CsvHelper library to parse the CSV text `name,age,city\nAlice,30,Paris\nBob,25,London\nCarol,35,Berlin\n` into rows via a `CsvReader`. The header row is skipped, and the first column (name) of each data row is joined with commas to print `Alice,Bob,Carol`.

## Run

    dotnet run
