# 0172 — Ring Buffer

Push 1,2,3,4,5 into a fixed capacity-3 ring buffer (overwriting oldest) and print the final contents `3 4 5`. A fixed `int[]` with modular `head`/`count` indices gives O(1) pushes that wrap around and overwrite the oldest slot.

## Run

    dotnet run
