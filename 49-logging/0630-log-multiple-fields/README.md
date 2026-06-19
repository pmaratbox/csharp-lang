# 0630 — Log multiple fields

Uses the [Serilog](https://serilog.net/) structured-logging library to emit a single INFO record with the message `request` and two structured fields, `method=GET` (string) and `status=200` (int), attached via `.ForContext(key, value)`. Capture happens entirely in memory through a custom `ILogEventSink` (the `Capture` class) wired up with `WriteTo.Sink(...)`, so no timestamp or console output leaks in. The sink reads each `LogEvent`'s `Level`, `MessageTemplate.Text`, and `Properties`, normalizes the level to `info`, sorts the fields by key, strips quotes from string values, and prints the normalized line `info|request|method=GET|status=200`.

## Run

    dotnet run
