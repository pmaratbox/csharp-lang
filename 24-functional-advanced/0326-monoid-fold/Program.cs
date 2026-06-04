static T Fold<T>(IEnumerable<T> xs, T identity, Func<T, T, T> combine)
{
    var acc = identity;
    foreach (var x in xs) acc = combine(acc, x);
    return acc;
}

var s = Fold(new[] { "a", "b", "c" }, "", (a, b) => a + b);
var n = Fold(new[] { 1, 2, 3 }, 0, (a, b) => a + b);

Console.WriteLine($"{s} {n}");
