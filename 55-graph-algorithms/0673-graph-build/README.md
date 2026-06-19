# 0673 — Build a graph

This program uses [QuikGraph](https://www.nuget.org/packages/QuikGraph), C#'s
graph data-structure and algorithms library, to construct the fixed weighted
undirected graph G (nodes `a,b,c,d,e` with six weighted edges) using an
`UndirectedGraph` and `AddVerticesAndEdge`. It then reports the graph's
`VertexCount` and `EdgeCount` space-joined, so the counts come from the
library's own bookkeeping rather than being hardcoded.

## Run

    dotnet run
