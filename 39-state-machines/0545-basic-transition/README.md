# 0545 — Basic transition

Uses the [Stateless](https://github.com/dotnet-state-machine/stateless) finite-state-machine library. A `StateMachine<string,string>` is configured with two states — `locked` and `unlocked` — where `Configure("locked").Permit("coin", "unlocked")` declares a *transition*: firing the `coin` trigger moves the machine from `locked` to `unlocked`. Starting in `locked` and calling `sm.Fire("coin")` advances the machine, and `sm.State` reports the resulting state.

## Run

    dotnet run
