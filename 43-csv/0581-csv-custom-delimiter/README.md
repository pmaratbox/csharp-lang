# 0581 — Custom delimiter

Uses the CsvHelper library to parse the semicolon-delimited CSV text `a;b;c\n1;2;3\n` by configuring `CsvConfiguration.Delimiter` to `;`. The second (data) row's fields are read via the `CsvReader` and joined with commas to print `1,2,3`.

## Run

    dotnet run
