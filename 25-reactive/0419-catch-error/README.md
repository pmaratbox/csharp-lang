# 0419 — Catch Error

Implement catchError that, on an error from the source, switches to a fallback stream. The from-scratch Observable wraps a subscribe closure, and the operator re-subscribes the same observer to the fallback inside onError.

## Run

    dotnet run
