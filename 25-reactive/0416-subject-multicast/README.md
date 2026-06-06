# 0416 — Subject Multicast

Implement a Subject that multicasts each emission to all current observers; two observers both receive 1 then 2. A `List<Action<T>>` holds the observers and `Next` iterates them in subscription order.

## Run

    dotnet run
