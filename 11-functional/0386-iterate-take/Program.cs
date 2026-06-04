static IEnumerable<int> Iterate(int seed, Func<int, int> f)
{
    var x = seed;
    while (true)
    {
        yield return x;
        x = f(x);
    }
}

var values = Iterate(1, x => x * 3).Take(4);
Console.WriteLine(string.Join(" ", values));
