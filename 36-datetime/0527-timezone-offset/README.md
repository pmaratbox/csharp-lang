# 0527 — Timezone offset

Using NodaTime, build the fixed UTC instant `2026-06-15T12:00:00Z` with `Instant.FromUtc`, apply a fixed `+05:00` offset via `WithOffset(Offset.FromHours(5))` (no named timezone / OS tzdata), and print the resulting local hour, yielding `17`.

## Run

    dotnet run
