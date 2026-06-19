# 0651 — Retries exhausted

Uses the [Polly.Core](https://github.com/App-vNext/Polly) retry strategy with `MaxRetryAttempts = 2` (2 retries = 3 total attempts) and zero delay. A scripted operation always throws, so every attempt fails and Polly re-throws the final exception once the retries are exhausted. We catch it and print `failed`.

## Run

    dotnet run
