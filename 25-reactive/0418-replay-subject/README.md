# 0418 — ReplaySubject

Implement a ReplaySubject with a buffer of the last 2 values, replayed to a late subscriber, which then also receives new values. A bounded `Queue<T>` holds the replay buffer, dequeuing the oldest value once it exceeds the buffer size.

## Run

    dotnet run
