# 0546 — Toggle

A finite state machine built with the [Stateless](https://github.com/dotnet-state-machine/stateless)
library. Two states, `off` and `on`, are wired so the single `toggle` trigger
flips between them — the classic two-state toggle. Starting from `off`, firing
`toggle` three times walks `off -> on -> off -> on`, leaving the machine in
`on`. The final state is read back from `sm.State` (never hardcoded) and printed
lowercased.

## Run

    dotnet run
