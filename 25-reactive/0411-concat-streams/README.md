# 0411 — Concat Streams

Implement concat: subscribe to the second source only after the first completes; concat [1,2] then [3,4]. The Concat factory chains subscriptions inside the second source's onComplete, so no scheduler is needed.

## Run

    dotnet run
