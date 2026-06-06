# 0404 — Cold vs Hot Observable

Contrast a cold observable (re-runs its producer per subscriber) with a hot one (shares a single execution, so late subscribers miss earlier values). The cold source is a producer closure replayed on each `Subscribe`, while the hot `Subject<T>` multicasts to whatever observers are currently in its subscriber list.

## Run

    dotnet run
