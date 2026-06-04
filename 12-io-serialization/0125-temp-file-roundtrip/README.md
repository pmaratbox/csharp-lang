# 0125 — Temp File Roundtrip

Write a string to a temporary file, read it back, confirm it matches, delete the file, and print `roundtrip: ok`. C# uses `Path.GetTempFileName` to allocate a unique temp path.

## Run

    dotnet run
