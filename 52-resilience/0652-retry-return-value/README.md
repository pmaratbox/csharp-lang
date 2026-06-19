# 0652 — Return a value

Uses [Polly.Core](https://github.com/App-vNext/Polly) `ResiliencePipelineBuilder.AddRetry`. A scripted operation throws on its first attempt and then returns the string `ok`. The retry strategy (zero delay, up to 5 total attempts) re-runs the failing call and `pipe.Execute` returns the eventual successful value, which we print — `ok` — rather than the attempt count.

## Run

    dotnet run
