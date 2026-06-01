# 0047 — Immutable Update (Copy-with)

Make a copy of the point `(1, 2)` with its `x` changed to `9`, leaving the original intact, and print `original: (1, 2)` then `updated: (9, 2)`. A record's `with` expression — `p1 with { X = 9 }` — clones the record and overrides the named properties, returning a new value. The original record is unchanged.

## Run

    dotnet run
