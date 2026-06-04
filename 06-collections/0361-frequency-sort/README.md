# 0361 — Frequency Sort

Sort [1,1,2,3,3,3] by descending frequency (ties keep first-seen order), printing `3 3 3 1 1 2`. `GroupBy` keeps first-seen key order and `OrderByDescending` is a stable sort, so equal counts retain their original order.

## Run

    dotnet run
