using QuikGraph;

// Build the fixed weighted undirected graph G with QuikGraph.
var g = new UndirectedGraph<string, TaggedUndirectedEdge<string, double>>();
void AddE(string u, string v, double w) =>
    g.AddVerticesAndEdge(new TaggedUndirectedEdge<string, double>(u, v, w));
foreach (var x in new[] { "a", "b", "c", "d", "e" }) g.AddVertex(x);
AddE("a", "b", 1); AddE("a", "c", 4); AddE("b", "c", 1);
AddE("b", "d", 5); AddE("c", "d", 1); AddE("d", "e", 1);

// Edge existence: b-c is present, a-e is not.
var bc = g.ContainsEdge("b", "c").ToString().ToLower();
var ae = g.TryGetEdge("a", "e", out _).ToString().ToLower();
Console.WriteLine($"{bc} {ae}");
