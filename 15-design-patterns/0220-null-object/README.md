# 0220 — Null Object

Compare a no-op null logger with a real logger; only the real one records, so print the logged count `1`. The `NullLogger` implements `ILogger` with an empty `Log`, avoiding null checks at the call site.

## Run

    dotnet run
