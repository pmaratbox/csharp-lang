void Check(int n)
{
    if (n > 100)
    {
        throw new TooLargeException();
    }
}

try
{
    Check(200);
}
catch (TooLargeException e)
{
    Console.WriteLine($"error: {e.Message}");
}

class TooLargeException : Exception
{
    public TooLargeException() : base("value too large") { }
}
