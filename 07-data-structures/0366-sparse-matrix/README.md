# 0366 — Sparse Matrix

Store only nonzero entries; with (1,1)=5 set, read (1,1) (5) and (0,0) (0), printing `5 0`. A `Dictionary` keyed by a `(row, col)` tuple plus an indexer reads missing keys as 0.

## Run

    dotnet run
