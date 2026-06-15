# 0548 — Guarded transition

Uses the [Stateless](https://github.com/dotnet-state-machine/stateless) finite-state-machine library. A *guarded transition* is one that is only valid from a specific source state: here the `open` event is configured solely on the `unlocked` state via `Configure("unlocked").Permit("open", "open")`, so it can never fire from `locked`. Starting in `locked`, firing `unlock` then `open` walks the machine to its final state, which is read back from `sm.State` and lowercased.

## Run

    dotnet run
