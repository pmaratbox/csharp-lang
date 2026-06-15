using NodaTime;
using NodaTime.Text;

// Parse two FIXED ISO dates with NodaTime, then let the library compute the
// number of whole days between them via Period.Between (Days unit).
LocalDate start = LocalDatePattern.Iso.Parse("2026-06-15").Value;
LocalDate end = LocalDatePattern.Iso.Parse("2026-07-15").Value;

int days = Period.Between(start, end, PeriodUnits.Days).Days;
Console.WriteLine(days);
