# 0579 — Extract a column

Uses the CsvHelper library to parse the fixed CSV text `name,age,city\nAlice,30,Paris\n...`. The reader reads the header row, looks up the index of the `age` column in `HeaderRecord`, then reads each data row and collects that field with `GetField`. The values are joined with commas to print `30,25,35`.

## Run

    dotnet run
