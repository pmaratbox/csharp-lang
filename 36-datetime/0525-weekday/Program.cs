using NodaTime;
using NodaTime.Text;

// Parse a FIXED ISO date with NodaTime, then ask the library for its day of
// week. NodaTime's IsoDayOfWeek enum is already ISO (Monday=1 .. Sunday=7),
// so casting it to int yields the ISO weekday number directly.
LocalDate date = LocalDatePattern.Iso.Parse("2026-06-15").Value;

int isoWeekday = (int)date.DayOfWeek;
Console.WriteLine(isoWeekday);
