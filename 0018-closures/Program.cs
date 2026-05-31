Func<int> next = Counter();
Console.WriteLine($"count: {next()}");
Console.WriteLine($"count: {next()}");

Func<int> Counter()
{
    int count = 0;
    return () => ++count;
}
