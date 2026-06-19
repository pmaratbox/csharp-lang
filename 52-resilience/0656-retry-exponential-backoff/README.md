# 0656 — Exponential backoff

Uses the [Polly.Core](https://github.com/App-vNext/Polly) retry strategy with `BackoffType = DelayBackoffType.Exponential` and a zero base delay. A scripted operation throws on its first three attempts and succeeds on the fourth, so Polly retries with an (instantaneous) exponential schedule until the call returns. We print the total attempt count `4`.

## Run

    dotnet run
