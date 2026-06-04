ISubject proxy = new VirtualProxy();
Console.WriteLine(proxy.Request());

interface ISubject { string Request(); }

sealed class RealSubject : ISubject
{
    public string Request() => "loaded";
}

sealed class VirtualProxy : ISubject
{
    private RealSubject? _real;
    public string Request()
    {
        _real ??= new RealSubject();
        return _real.Request();
    }
}
