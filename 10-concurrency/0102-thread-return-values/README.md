# 0102 — Threads Returning Values

Run two threads that compute the squares of 3 and 4, join them, and print the sum of their results `25`. Each thread writes its square into a shared result array, then `Join` makes the values safe to read.

## Run

    dotnet run
