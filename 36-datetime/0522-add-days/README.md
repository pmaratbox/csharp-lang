# 0522 — Add days

This lesson uses **NodaTime**, a real date/time library for .NET. It parses the
fixed date `2026-06-15` into a `LocalDate` with `LocalDatePattern.Iso`, adds ten
days using the calendar-aware `PlusDays` method, and formats the result back to
an ISO `yyyy-MM-dd` string. The computation is done entirely by the library on a
fixed instant — never the current time.

## Run

    dotnet run
