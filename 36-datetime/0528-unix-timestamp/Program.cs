using NodaTime;

// Build the FIXED UTC instant 2026-06-15T00:00:00Z with NodaTime,
// then ask the library for its Unix timestamp in epoch SECONDS.
Instant instant = Instant.FromUtc(2026, 6, 15, 0, 0, 0);
Console.WriteLine(instant.ToUnixTimeSeconds());
