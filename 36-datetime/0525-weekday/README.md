# 0525 — Weekday

Using the NodaTime library, parse the fixed ISO date `2026-06-15` with
`LocalDatePattern.Iso`, then read its `DayOfWeek`. NodaTime's `IsoDayOfWeek`
enum follows ISO numbering (Monday=1 .. Sunday=7), so casting the value to
`int` gives the ISO weekday number — `1` for this Monday.

## Run

    dotnet run
