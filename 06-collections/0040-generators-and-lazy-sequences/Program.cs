IEnumerable<int> Squares()
{
    int n = 1;
    while (true)
    {
        yield return n * n;
        n++;
    }
}

Console.WriteLine(string.Join(" ", Squares().Take(3)));
