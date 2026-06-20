# 0709 — Nil UUID

The nil UUID is the special all-zero value `00000000-0000-0000-0000-000000000000`. In C# this comes from the built-in `System.Guid` type as `Guid.Empty` (no external package required); calling `.ToString()` renders it in the canonical lowercase hyphenated form.

## Run

    dotnet run
