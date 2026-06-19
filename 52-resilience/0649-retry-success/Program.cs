using Polly;
using Polly.Retry;

// A scripted operation that simply succeeds on its first call.
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

// Succeeds first try: the body never throws, so Polly never retries.
pipe.Execute(() =>
{
    n++;
    return "done";
});

Console.WriteLine(n);   // 1 — no retry needed
