# 0015 — Interfaces

Define a `Shape` interface with `name()` and `area()` methods, implement it for a rectangle and a square, then loop over a collection of shapes and print each one's area. C# names interfaces with a leading `I`, so the contract here is `IShape`, and each shape is a `record` that both stores its fields and inherits `: IShape` — the record's positional `Width`/`Height` parameters feed the `Area()` calculation. A `List<IShape>` holds either type, and iterating it calls `s.Area()` through the interface, dispatching to the actual record at runtime.

## Run

    dotnet run
