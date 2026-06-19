# 0632 — Level filtering

Uses the [Serilog](https://serilog.net/) structured-logging library configured with `MinimumLevel.Warning()`, so records below WARN are dropped before they ever reach a sink. The program logs an INFO record `hidden` (suppressed) and a WARN record `visible`. Capture happens entirely in memory through a custom `ILogEventSink` (the `Capture` class) wired up with `WriteTo.Sink(...)`, so no timestamp or console output leaks in. The sink only ever sees the warn record; it reads the `LogEvent`'s `Level` and `MessageTemplate.Text`, normalizes the level to `warn`, and prints the normalized line `warn|visible`.

## Run

    dotnet run
