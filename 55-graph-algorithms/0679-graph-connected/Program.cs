using QuikGraph;
using QuikGraph.Algorithms.Observers;
using QuikGraph.Algorithms.ShortestPath;

// Build the fixed weighted undirected graph G.
var g = new UndirectedGraph<string, TaggedUndirectedEdge<string, double>>();
void AddE(string u, string v, double w) =>
    g.AddVerticesAndEdge(new TaggedUndirectedEdge<string, double>(u, v, w));

foreach (var x in new[] { "a", "b", "c", "d", "e" }) g.AddVertex(x);
AddE("a", "b", 1); AddE("a", "c", 4); AddE("b", "c", 1);
AddE("b", "d", 5); AddE("c", "d", 1); AddE("d", "e", 1);

// Connectivity a -> e: run Dijkstra from a; e is reachable if it has a distance.
var dij = new UndirectedDijkstraShortestPathAlgorithm<string, TaggedUndirectedEdge<string, double>>(
    g, e => e.Tag);
var rec = new UndirectedVertexPredecessorRecorderObserver<string, TaggedUndirectedEdge<string, double>>();
using (rec.Attach(dij)) dij.Compute("a");

var connected = dij.Distances.ContainsKey("e");
Console.WriteLine(connected.ToString().ToLower());
