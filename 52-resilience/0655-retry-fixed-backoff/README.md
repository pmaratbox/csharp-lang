# 0655 — Fixed backoff

Uses the [Polly](https://github.com/App-vNext/Polly) `Polly.Core` retry strategy with a FIXED (constant) backoff and a zero delay. A scripted operation fails twice then succeeds; the `ResiliencePipelineBuilder().AddRetry(...)` pipeline catches each failure and re-runs the body, so a shared counter records 3 total attempts before the success.

## Run

    dotnet run
