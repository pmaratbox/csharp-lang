# 0523 — Difference in days

Use NodaTime's `LocalDatePattern.Iso` to parse two fixed ISO dates (`2026-06-15` and `2026-07-15`), then ask the library for the gap between them with `Period.Between(..., PeriodUnits.Days)` and read its `.Days`. The day count is computed by the library, not hardcoded.

## Run

    dotnet run
