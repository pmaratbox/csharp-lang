# 0680 — Topological sort

This program uses [QuikGraph](https://www.nuget.org/packages/QuikGraph), C#'s
graph data-structure and algorithms library, to compute a topological ordering
of a fixed directed acyclic graph (DAG) with edges `a->b`, `b->c`, `a->c`,
`c->d`, `d->e`. It calls QuikGraph's `TopologicalSort()` on an
`AdjacencyGraph`, which returns the unique linear order `a,b,c,d,e` where every
edge points from an earlier vertex to a later one.

## Run

    dotnet run
