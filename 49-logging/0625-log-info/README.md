# 0625 — Log at info level

Uses the [Serilog](https://serilog.net/) structured-logging library to emit a single INFO record with the message `service started` and no structured fields. Capture happens entirely in memory through a custom `ILogEventSink` (the `Capture` class) wired up with `WriteTo.Sink(...)`, so no timestamp or console output leaks in. The sink reads each `LogEvent`'s `Level` and `MessageTemplate.Text`, normalizes the level to the short form `info`, and prints the normalized line `info|service started`.

## Run

    dotnet run
