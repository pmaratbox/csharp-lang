# 0307 — A* on a Grid

Find the shortest path length from (0,0) to (2,2) on an obstacle-free 3x3 grid (4-directional) with the Manhattan heuristic, printing `4`. A `PriorityQueue` ordered by `g + h` drives the A* frontier over tuple coordinates.

## Run

    dotnet run
