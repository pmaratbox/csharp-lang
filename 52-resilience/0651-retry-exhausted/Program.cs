using Polly;
using Polly.Retry;

int n = 0;

var pipe = new ResiliencePipelineBuilder()
    .AddRetry(new RetryStrategyOptions
    {
        MaxRetryAttempts = 2, // 2 retries => 3 total attempts
        Delay = TimeSpan.Zero,
        BackoffType = DelayBackoffType.Constant,
        ShouldHandle = new PredicateBuilder().Handle<Exception>()
    })
    .Build();

try
{
    // Scripted failure: always throws, so the retries are exhausted.
    pipe.Execute(() =>
    {
        n++;
        throw new Exception("always fails");
    });
}
catch (Exception)
{
    Console.WriteLine("failed");
}
