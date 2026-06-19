# 0675 — Neighbors

This program uses [QuikGraph](https://www.nuget.org/packages/QuikGraph), C#'s
graph data-structure and algorithms library, to build the fixed weighted
undirected graph G and list the neighbors of node `a`. It reads the adjacent
edges via `UndirectedGraph.AdjacentEdges`, maps each edge to its other
endpoint, and sorts the result for a deterministic output.

## Run

    dotnet run
