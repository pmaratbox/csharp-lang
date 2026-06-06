# 0414 — FlatMap (mergeMap)

Implement flatMap/mergeMap: map each outer value to an inner timed stream and merge all inners concurrently (no cancellation). A virtual-time `Scheduler` backed by `PriorityQueue<Action,(long,long)>` keeps the merge fully deterministic.

## Run

    dotnet run
