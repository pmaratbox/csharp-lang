# 0678 — Shortest path route

This program uses [QuikGraph](https://www.nuget.org/packages/QuikGraph), C#'s
graph data-structure and algorithms library, to compute the unique weighted
shortest path on a fixed undirected graph `G`. It runs QuikGraph's
`UndirectedDijkstraShortestPathAlgorithm` from vertex `a` with a
`UndirectedVertexPredecessorRecorderObserver`, reconstructs the node sequence
to `e`, and joins it with `-`, yielding `a-b-c-d-e` (cost `4`).

## Run

    dotnet run
