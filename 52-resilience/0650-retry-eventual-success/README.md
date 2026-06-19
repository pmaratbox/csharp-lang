# 0650 — Eventual success

Uses the [Polly](https://github.com/App-vNext/Polly) `Polly.Core` resilience pipeline with an `AddRetry` strategy (up to 5 total attempts, zero delay). The wrapped operation throws on its first call and succeeds on the next, so Polly retries exactly once — the shared attempt counter ends at `2`.

## Run

    dotnet run
