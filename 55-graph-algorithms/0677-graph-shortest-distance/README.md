# 0677 — Shortest distance

This program uses [QuikGraph](https://www.nuget.org/packages/QuikGraph), C#'s
graph data-structure and algorithms library, to compute the weighted
shortest-path distance on a fixed undirected graph `G`. It runs QuikGraph's
`UndirectedDijkstraShortestPathAlgorithm` from vertex `a` and reads the
resulting distance to `e`, which is `4` along the unique path `a-b-c-d-e`.

## Run

    dotnet run
