# 0434 — FlatMap (mergeMap)

Use the library's flatMap/mergeMap on a virtual/test scheduler, mapping each outer value to a timed inner stream and merging them. Uses System.Reactive (Rx.NET) `SelectMany` (mergeMap) over a `TestScheduler`.

## Run

    dotnet run
