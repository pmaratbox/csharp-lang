# 0552 — Workflow

Uses the [Stateless](https://github.com/dotnet-state-machine/stateless) finite-state-machine library to model a multi-step approval workflow. Each state is declared with `Configure(...)` and given outgoing transitions via `.Permit(trigger, destination)`: `idle --submit--> pending` and `pending --approve--> approved`. Firing the fixed event sequence `submit` then `approve` drives the machine through its states, and `sm.State` reports the resulting state, which we lowercase before printing.

## Run

    dotnet run
