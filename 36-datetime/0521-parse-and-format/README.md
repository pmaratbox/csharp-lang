# 0521 — Parse & format

Use NodaTime's `LocalDatePattern.Iso` to parse the fixed ISO date `2026-06-15` into a `LocalDate`, then format that value back to ISO (`yyyy-MM-dd`). The library performs the round-trip parse and format; nothing is hardcoded.

## Run

    dotnet run
