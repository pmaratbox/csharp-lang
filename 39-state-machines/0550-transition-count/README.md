# 0550 — Transition count

Uses the [Stateless](https://github.com/dotnet-state-machine/stateless) finite-state-machine library. States `a -> b -> c -> d` are wired with `Configure(...).Permit("next", ...)`, and an `OnTransitioned` callback fires an action on *every* transition the machine performs, incrementing a counter. Firing the fixed sequence of three valid `next` events drives the counter to `3` — the value is produced by the per-transition action, not hardcoded.

## Run

    dotnet run
