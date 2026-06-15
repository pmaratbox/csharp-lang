# 0528 — Unix timestamp

Use NodaTime's `Instant.FromUtc` to construct the fixed UTC instant `2026-06-15T00:00:00Z`, then call `ToUnixTimeSeconds()` to let the library compute its Unix timestamp (epoch seconds). The value is derived by NodaTime, not hardcoded.

## Run

    dotnet run
