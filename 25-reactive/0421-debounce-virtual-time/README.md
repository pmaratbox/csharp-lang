# 0421 — Debounce (Virtual Time)

Implement debounce(window) on a virtual-time scheduler: emit a value only after a quiet gap of `window` ticks with no newer value. A `Token` whose `Cancelled` flag the scheduler checks on dequeue gives idiomatic O(1) cancellation of the pending emit.

## Run

    dotnet run
