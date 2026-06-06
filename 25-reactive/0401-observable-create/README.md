# 0401 — Create an Observable

Build a push-based Observable from scratch that emits 1, 2, 3 to its observer and then completes. The Observable wraps a subscribe `Action<Observer<T>>`, idiomatic in C# for closing over a producer.

## Run

    dotnet run
