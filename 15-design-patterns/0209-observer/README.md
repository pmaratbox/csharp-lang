# 0209 — Observer

Notify two observers of a new value 5; each prints its id and the value on its own line. The subject holds a list of `IObserver` and calls `Update` on each during `Notify`.

## Run

    dotnet run
