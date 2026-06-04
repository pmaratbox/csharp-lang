static IEnumerable<int> Naturals()
{
    var n = 1;
    while (true) yield return n++;
}

Console.WriteLine(string.Join(' ', Naturals().Where(x => x % 2 == 0).Take(3)));
