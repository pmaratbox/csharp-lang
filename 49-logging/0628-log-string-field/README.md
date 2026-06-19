# 0628 — Log a string field

Uses the **Serilog** structured-logging library. A custom `ILogEventSink` (`Capture`) buffers each `LogEvent` in memory, so no real timestamp ever reaches the output. A string field is attached with `.ForContext("user", "alice")` and a plain message `login` is logged at info level. The sink reads `LogEvent.Level`, `MessageTemplate.Text`, and `Properties` (sorted by key, string values unquoted) to print the normalized line `info|login|user=alice`.

## Run

    dotnet run
