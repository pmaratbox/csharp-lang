# 0653 — Count attempts

Uses the [Polly.Core](https://github.com/App-vNext/Polly) retry strategy with `MaxRetryAttempts = 4` (4 retries = 5 total attempts) and zero delay. A scripted operation always throws and increments a shared counter on each invocation, so Polly drives all 5 attempts before re-throwing. We catch the final exception and print the counter — the total number of attempts the library made: `5`.

## Run

    dotnet run
