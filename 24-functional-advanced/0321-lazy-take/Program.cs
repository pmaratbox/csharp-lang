static IEnumerable<int> Naturals()
{
    var n = 1;
    while (true) yield return n++;
}

Console.WriteLine(string.Join(' ', Naturals().Take(5)));
