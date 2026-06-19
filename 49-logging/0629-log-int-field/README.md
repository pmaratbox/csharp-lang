# 0629 — Log an integer field

Uses the **Serilog** structured-logging library. A custom `ILogEventSink` (`Capture`) is wired up via `WriteTo.Sink(...)` so every `LogEvent` is buffered in memory instead of being written to a console or file — no real timestamp is ever rendered. We attach an integer structured field with `.ForContext("count", 5)` and log a plain INFO message `processed`. The sink reads `LogEvent.Level` (normalized `Information` -> `info`), `MessageTemplate.Text`, and the `Properties` (sorted by key, integers printed as-is) to emit the normalized line `info|processed|count=5`.

## Run

    dotnet run
