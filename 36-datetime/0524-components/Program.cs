using NodaTime;
using NodaTime.Text;

// Fixed date, never the current time.
LocalDate d = LocalDatePattern.Iso.Parse("2026-06-15").Value;

Console.WriteLine(d.Year);
Console.WriteLine(d.Month);
Console.WriteLine(d.Day);
