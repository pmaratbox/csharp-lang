using Polly;
using Polly.Retry;

// A scripted operation: it fails once, then returns the string "ok".
// The shared counter `n` is incremented on every attempt the pipeline drives.
int n = 0;

var pipe = new ResiliencePipelineBuilder()
    .AddRetry(new RetryStrategyOptions
    {
        MaxRetryAttempts = 4,                 // up to 5 total attempts allowed
        Delay = TimeSpan.Zero,                // no waiting — result is delay-independent
        BackoffType = DelayBackoffType.Constant,
        ShouldHandle = new PredicateBuilder().Handle<Exception>(),
    })
    .Build();

// First call throws, second call returns "ok".
// Polly retries the failure and hands back the eventual successful value.
string result = pipe.Execute(() =>
{
    n++;
    if (n < 2) throw new Exception("fail");
    return "ok";
});

Console.WriteLine(result);   // ok — the returned value, not the attempt count
