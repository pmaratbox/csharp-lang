var parts = new List<int>();

void Run()
{
    using var a = new Deferred(() => parts.Add(1));
    using var b = new Deferred(() => parts.Add(2));
    using var c = new Deferred(() => parts.Add(3));
}

Run();
Console.WriteLine(string.Join(' ', parts));

sealed class Deferred(Action action) : IDisposable
{
    public void Dispose() => action();
}
