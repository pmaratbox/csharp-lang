try
{
    throw new SpecificError();
}
catch (InvalidOperationException)
{
    Console.WriteLine("caught base");
}

class SpecificError : InvalidOperationException
{
    public SpecificError() : base("specific") { }
}
