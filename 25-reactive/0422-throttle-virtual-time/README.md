# 0422 — Throttle (Virtual Time)

Implement throttle(window) (leading edge) on a virtual-time scheduler: emit a value, then suppress further values for `window` ticks. In C#, `PriorityQueue<TElement,TPriority>` with a `(time, seq)` tuple priority orders events deterministically and breaks ties by insertion order.

## Run

    dotnet run
