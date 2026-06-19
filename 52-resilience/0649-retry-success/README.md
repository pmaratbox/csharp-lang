# 0649 — Succeeds first try

Uses the [Polly](https://github.com/App-vNext/Polly) `Polly.Core` resilience pipeline with an `AddRetry` strategy (up to 5 total attempts, zero delay). The wrapped operation succeeds on its very first call, so the retry strategy never fires — the shared attempt counter ends at `1`.

## Run

    dotnet run
