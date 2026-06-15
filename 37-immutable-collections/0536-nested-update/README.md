# 0536 — Nested update

Use `System.Collections.Immutable`'s `ImmutableDictionary` to model a nested map `{ user: { age: 30 } }`. Updating the nested `user.age` rebuilds the path with `SetItem` on the inner map and then `SetItem` on the outer map — each call RETURNS A NEW map, so the new map shows `31` while the original is left unchanged at `30`.

## Run

    dotnet run
