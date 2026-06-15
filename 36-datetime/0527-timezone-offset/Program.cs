using NodaTime;

// Fixed UTC instant: 2026-06-15T12:00:00Z (NEVER the current time).
Instant instant = Instant.FromUtc(2026, 6, 15, 12, 0, 0);

// Convert to a FIXED +05:00 offset (no named tz / OS tzdata).
OffsetDateTime local = instant.WithOffset(Offset.FromHours(5));

// Print the resulting local hour -> 17.
Console.WriteLine(local.Hour);
