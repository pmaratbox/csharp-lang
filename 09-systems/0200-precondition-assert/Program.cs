void Check(int arg)
{
    if (arg <= 0)
        throw new ArgumentException("must be positive");
    Console.WriteLine("ok");
}

foreach (var arg in new[] { 5, -1 })
{
    try
    {
        Check(arg);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"error: {ex.Message}");
    }
}
