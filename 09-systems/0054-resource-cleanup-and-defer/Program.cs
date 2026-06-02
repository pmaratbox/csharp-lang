using (var resource = new Resource())
{
    Console.WriteLine("use");
}

class Resource : IDisposable
{
    public Resource() => Console.WriteLine("open");
    public void Dispose() => Console.WriteLine("close");
}
