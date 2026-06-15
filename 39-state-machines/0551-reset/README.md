# 0551 — Reset

Uses the [Stateless](https://github.com/dotnet-state-machine/stateless) finite-state-machine library. Two states are wired up with `Configure(...).Permit(trigger, target)`: `idle --start--> running` and `running --reset--> idle`. After firing `start` (to `running`) and then `reset`, the `reset` transition returns the machine to its initial state. The final `sm.State` is read back from the machine and printed lowercased, yielding `idle`.

## Run

    dotnet run
