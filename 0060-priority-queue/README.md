# 0060 — Priority Queue

Push `3`, `1`, and `2` into a min-priority-queue, then pop them all and print them in priority (ascending) order: `1 2 3`. `PriorityQueue<TElement, TPriority>` (since .NET 6) is a min-heap: `Enqueue(value, priority)` and `Dequeue()` removes the lowest-priority (here smallest) element.

## Run

    dotnet run
