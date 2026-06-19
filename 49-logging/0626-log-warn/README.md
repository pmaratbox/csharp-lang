# 0626 — Log at warn level

Uses the **Serilog** structured-logging library to emit a single WARN record with the message `low disk` and no structured fields. A custom `ILogEventSink` (`Capture`) is wired into the logger via `WriteTo.Sink(...)`, so each `LogEvent` is captured in memory — no real timestamp ever reaches the output. The sink reads `LogEvent.Level`, `MessageTemplate.Text` and `Properties`, normalizing the level from `Warning` to the short form `warn`, and prints the line `warn|low disk`.

## Run

    dotnet run
