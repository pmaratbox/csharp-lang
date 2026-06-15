# 0549 — Invalid transition

Uses the [Stateless](https://github.com/dotnet-state-machine/stateless) finite-state-machine library. The turnstile is configured with `Configure("locked").Permit("coin", "unlocked")` and `Configure("unlocked").Permit("push", "locked")`. Firing `push` while in `locked` is an *invalid transition* — there is no rule for it, so `OnUnhandledTrigger` swallows the event and the machine remains in its current state rather than throwing. `sm.State.ToLower()` then reports `locked`.

## Run

    dotnet run
