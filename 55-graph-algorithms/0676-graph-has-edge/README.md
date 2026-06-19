# 0676 — Edge existence

This program uses [QuikGraph](https://www.nuget.org/packages/QuikGraph), C#'s
graph data-structure and algorithms library. It builds the fixed weighted
undirected graph G and asks the graph directly whether two edges exist:
`ContainsEdge("b", "c")` (present) and `TryGetEdge("a", "e", out _)` (absent),
printing the two boolean results lowercase and space-joined.

## Run

    dotnet run
