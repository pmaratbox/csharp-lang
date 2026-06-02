string Classify(int n)
{
    if (n < 0) return "negative";
    if (n == 0) return "zero";
    return "positive";
}

foreach (var n in new[] { -1, 0, 5 })
{
    Console.WriteLine(Classify(n));
}
