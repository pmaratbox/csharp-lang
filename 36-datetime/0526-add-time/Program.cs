using NodaTime;
using NodaTime.Text;

// Fixed instant: parse the local time 10:00 from a fixed ISO datetime.
LocalDateTime start = LocalDateTimePattern.GeneralIso.Parse("2026-06-15T10:00:00").Value;

// Add 90 minutes via the library.
LocalDateTime result = start.PlusMinutes(90);

// Format as HH:mm.
Console.WriteLine(LocalTimePattern.CreateWithInvariantCulture("HH:mm").Format(result.TimeOfDay));
