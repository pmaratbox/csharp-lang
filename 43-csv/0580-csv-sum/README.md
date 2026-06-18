# 0580 — Sum a numeric column

Uses the CsvHelper library to parse the `name,age,city` CSV text with a `CsvReader`. The `age` column is located via the header row, each data field is parsed to an integer, and the values are summed (30+25+35) to print `90`.

## Run

    dotnet run
