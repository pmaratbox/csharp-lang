# 0417 — BehaviorSubject

Implement a BehaviorSubject that holds a current value and replays it immediately to each new subscriber. In C# the subject stores the latest value and invokes each subscriber's `Action<T>` closure on subscribe, returning an `IDisposable` for teardown.

## Run

    dotnet run
