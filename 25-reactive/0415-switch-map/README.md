# 0415 — SwitchMap

Implement switchMap: when a new outer value arrives, cancel the previous inner subscription before starting the new one. Each inner records the scheduler tokens of its pending emissions so a new outer can cancel them.

## Run

    dotnet run
