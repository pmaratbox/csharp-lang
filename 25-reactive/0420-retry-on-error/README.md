# 0420 — Retry On Error

Implement retry(n) that resubscribes to the source on error up to n times; the source succeeds on the 3rd subscription. In C# the operator is a closure-based resubscribe that re-invokes the producer's `Action<Observer<T>>` on each error.

## Run

    dotnet run
