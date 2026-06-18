# 0582 — Filter rows

Uses the CsvHelper library to parse the fixed CSV text `name,age,city\nAlice,30,Paris\nBob,25,London\nCarol,35,Berlin\n`. After skipping the header, the data rows are filtered with a predicate keeping only those whose `age` field is greater than 28 (Alice 30 and Carol 35; Bob 25 is excluded), and the kept names are joined with commas to print `Alice,Carol`.

## Run

    dotnet run
