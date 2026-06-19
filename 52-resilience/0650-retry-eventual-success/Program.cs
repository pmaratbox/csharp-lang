using Polly;
using Polly.Retry;

// A scripted operation: it FAILS on the first attempt, then SUCCEEDS.
// The shared counter `n` records how many attempts the pipeline drives.
int n = 0;

var pipe = new ResiliencePipelineBuilder()
    .AddRetry(new RetryStrategyOptions
    {
        MaxRetryAttempts = 4,                 // up to 5 total attempts allowed
        Delay = TimeSpan.Zero,                // no waiting — count is delay-independent
        BackoffType = DelayBackoffType.Constant,
        ShouldHandle = new PredicateBuilder().Handle<Exception>(),
    })
    .Build();

// Fails once (n == 1) then succeeds (n == 2). Polly catches the first
// exception and retries, so the body actually runs twice.
pipe.Execute(() =>
{
    n++;
    if (n < 2) throw new Exception("transient");
    return "done";
});

Console.WriteLine(n);   // 2 — one failure, then success on the retry
