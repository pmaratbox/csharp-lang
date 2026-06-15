using NodaTime;
using NodaTime.Text;

// Parse a FIXED date (never the current time), add 10 days via the library's
// date arithmetic, then format the result back to ISO (yyyy-MM-dd).
LocalDate start = LocalDatePattern.Iso.Parse("2026-06-15").Value;
LocalDate result = start.PlusDays(10);
Console.WriteLine(LocalDatePattern.Iso.Format(result));
