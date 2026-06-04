static IEnumerable<int> Unfold(int seed, Func<int, int> next)
{
    var x = seed;
    while (true)
    {
        yield return x;
        x = next(x);
    }
}

var terms = Unfold(1, x => x * 2).Take(5);
Console.WriteLine(string.Join(" ", terms));
