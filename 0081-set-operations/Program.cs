var a = new HashSet<int> { 1, 2, 3 };
var b = new HashSet<int> { 2, 3, 4 };

var union = new HashSet<int>(a);
union.UnionWith(b);

var inter = new HashSet<int>(a);
inter.IntersectWith(b);

Console.WriteLine(string.Join(" ", union.OrderBy(x => x)));
Console.WriteLine(string.Join(" ", inter.OrderBy(x => x)));
