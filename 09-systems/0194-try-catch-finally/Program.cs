try
{
    throw new InvalidOperationException("boom");
}
catch (InvalidOperationException)
{
    Console.WriteLine("caught");
}
finally
{
    Console.WriteLine("cleanup");
}
