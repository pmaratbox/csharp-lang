# 0679 — Connectivity

This program uses [QuikGraph](https://www.nuget.org/packages/QuikGraph), C#'s
graph data-structure and algorithms library, to test whether a path exists
between `a` and `e` in the fixed weighted undirected graph G. It runs
`UndirectedDijkstraShortestPathAlgorithm` from `a` and asks whether `e` ended
up in the algorithm's `Distances` map: a vertex is reachable (connected) only
if Dijkstra assigned it a distance, so the boolean comes from the library's own
traversal rather than being hardcoded.

## Run

    dotnet run
