using QuikGraph;
using QuikGraph.Algorithms;

// Build the fixed DAG (directed acyclic graph).
var dag = new AdjacencyGraph<string, Edge<string>>();
foreach (var x in new[] { "a", "b", "c", "d", "e" }) dag.AddVertex(x);
foreach (var (u, v) in new[] { ("a", "b"), ("b", "c"), ("a", "c"), ("c", "d"), ("d", "e") })
    dag.AddEdge(new Edge<string>(u, v));

// Topological order (unique for this DAG) via QuikGraph.
Console.WriteLine(string.Join(",", dag.TopologicalSort()));
