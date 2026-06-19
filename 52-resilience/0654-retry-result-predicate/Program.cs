using Polly;
using Polly.Retry;

// A scripted operation: each attempt returns an incrementing counter (1, 2, 3, ...).
// We retry based on the RETURNED VALUE (not on an exception): keep retrying while the
// result is < 3. The third attempt returns 3, which the predicate accepts.
int n = 0;

var pipe = new ResiliencePipelineBuilder<int>()
    .AddRetry(new RetryStrategyOptions<int>
    {
        MaxRetryAttempts = 5,                              // plenty of retries available
        Delay = TimeSpan.Zero,                             // no waiting — result is delay-independent
        BackoffType = DelayBackoffType.Constant,
        ShouldHandle = new PredicateBuilder<int>()
            .HandleResult(v => v < 3),                     // retry while the value is too small
    })
    .Build();

// Polly drives the operation, inspecting each returned value and retrying until
// it sees a value >= 3. The accepted result is handed back.
int result = pipe.Execute(() => ++n);

Console.WriteLine(result);   // 3 — the first accepted result (returned on the 3rd attempt)
