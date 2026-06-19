using Polly;
using Polly.Retry;

int n = 0;

var pipe = new ResiliencePipelineBuilder()
    .AddRetry(new RetryStrategyOptions
    {
        MaxRetryAttempts = 4,
        Delay = TimeSpan.Zero,                  // zero base delay: the count is delay-independent
        BackoffType = DelayBackoffType.Exponential,
        ShouldHandle = new PredicateBuilder().Handle<Exception>()
    })
    .Build();

// Scripted failure: fails the first three times, then succeeds on the fourth attempt.
pipe.Execute(() =>
{
    n++;
    if (n < 4) throw new Exception("transient");
    return "done";
});

Console.WriteLine(n); // total attempts -> 4
