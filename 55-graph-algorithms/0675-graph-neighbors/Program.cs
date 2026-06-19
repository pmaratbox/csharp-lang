using QuikGraph;

// Fixed weighted undirected graph G: nodes a,b,c,d,e.
var g = new UndirectedGraph<string, TaggedUndirectedEdge<string, double>>();
void AddE(string u, string v, double w) =>
    g.AddVerticesAndEdge(new TaggedUndirectedEdge<string, double>(u, v, w));
foreach (var x in new[] { "a", "b", "c", "d", "e" }) g.AddVertex(x);
AddE("a", "b", 1); AddE("a", "c", 4); AddE("b", "c", 1);
AddE("b", "d", 5); AddE("c", "d", 1); AddE("d", "e", 1);

// Neighbors of node a, derived from the graph's adjacent edges, sorted.
var neighbors = g.AdjacentEdges("a")
    .Select(e => e.Source == "a" ? e.Target : e.Source)
    .OrderBy(x => x);
Console.WriteLine(string.Join(",", neighbors));
