# 0654 — Retry on result

Uses the [Polly.Core](https://github.com/App-vNext/Polly) retry strategy with a
result predicate instead of an exception filter. A scripted operation returns an
incrementing counter, and `ShouldHandle = new PredicateBuilder<int>().HandleResult(v => v < 3)`
tells Polly to retry while the returned value is too small. The third attempt
returns `3`, which the predicate accepts, so Polly hands that value back. Delays
are zero, so the printed result is delay-independent.

## Run

    dotnet run
