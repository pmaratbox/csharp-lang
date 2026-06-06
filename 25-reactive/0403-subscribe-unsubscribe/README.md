# 0403 — Subscribe and Unsubscribe

Return a Subscription from subscribe() and use it to unsubscribe so later values are not delivered. In C# the Subscription exposes a Closed flag the producer reads before each push, and the consumer callback receives its own Subscription to call Unsubscribe() mid-stream.

## Run

    dotnet run
