# 0631 — Deterministic field order

Uses the **Serilog** structured-logging library. A custom `ILogEventSink` (`Capture`) buffers each `LogEvent` in memory, so no real timestamp ever reaches the output. Two integer fields are attached in NON-alphabetical order with `.ForContext("zeta", 2).ForContext("alpha", 1)`, and a plain message `metric` is logged at info level. The sink reads `LogEvent.Level`, `MessageTemplate.Text`, and `Properties`, sorting the fields by key so the normalized line is deterministic: `info|metric|alpha=1|zeta=2`.

## Run

    dotnet run
