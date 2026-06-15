using NodaTime;
using NodaTime.Text;

// Parse a FIXED ISO date with NodaTime, then format it back to ISO (yyyy-MM-dd).
LocalDate date = LocalDatePattern.Iso.Parse("2026-06-15").Value;
Console.WriteLine(LocalDatePattern.Iso.Format(date));
