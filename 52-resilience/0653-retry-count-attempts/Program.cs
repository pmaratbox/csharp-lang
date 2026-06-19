using Polly;
using Polly.Retry;

int attempts = 0;

var pipe = new ResiliencePipelineBuilder()
    .AddRetry(new RetryStrategyOptions
    {
        MaxRetryAttempts = 4, // 4 retries => 5 total attempts
        Delay = TimeSpan.Zero,
        BackoffType = DelayBackoffType.Constant,
        ShouldHandle = new PredicateBuilder().Handle<Exception>()
    })
    .Build();

try
{
    // Scripted failure: always throws, so Polly runs every attempt.
    pipe.Execute(() =>
    {
        attempts++;
        throw new Exception("always fails");
    });
}
catch (Exception)
{
    // Retries exhausted; report how many attempts the library actually made.
    Console.WriteLine(attempts);
}
