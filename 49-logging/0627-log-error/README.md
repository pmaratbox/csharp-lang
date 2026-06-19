# 0627 — Log at error level

Uses the **Serilog** structured-logging library. A custom `ILogEventSink` (`Capture`) is wired up via `WriteTo.Sink(...)` so every `LogEvent` is buffered in memory instead of being written to a console or file — no real timestamp is ever rendered. We log an ERROR record with the message `boom`, then the sink reads `LogEvent.Level` (normalized `Error` -> `error`) and `MessageTemplate.Text` and prints the normalized line `error|boom`.

## Run

    dotnet run
