# 0577 — Quoted CSV fields

Uses the CsvHelper library to parse the fixed CSV text `name,note\nAlice,"hello, world"\n`. The `note` field is quoted because it contains a comma; the reader correctly unquotes it so the embedded comma is preserved, and `GetField(1)` returns the data row's note value, printed as `hello, world`.

## Run

    dotnet run
