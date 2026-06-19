using Polly;
using Polly.Retry;

// A scripted operation that FAILS twice, then SUCCEEDS on the third try.
// The shared counter `n` records how many attempts the pipeline drives.
int n = 0;

var pipe = new ResiliencePipelineBuilder()
    .AddRetry(new RetryStrategyOptions
    {
        MaxRetryAttempts = 4,                  // up to 5 total attempts allowed
        Delay = TimeSpan.Zero,                 // FIXED backoff with zero wait
        BackoffType = DelayBackoffType.Constant, // constant (fixed) delay strategy
        ShouldHandle = new PredicateBuilder().Handle<Exception>(),
    })
    .Build();

// Fails on attempts 1 and 2 (n < 3), then succeeds on attempt 3. Polly catches
// each exception and retries with the fixed delay, so the body runs three times.
pipe.Execute(() =>
{
    n++;
    if (n < 3) throw new Exception("transient");
    return "done";
});

Console.WriteLine(n);   // 3 — two failures, then success on the third attempt
