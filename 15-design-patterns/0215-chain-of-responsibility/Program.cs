var h1 = new Handler(1);
var h2 = new Handler(2);
var h3 = new Handler(3);
h1.SetNext(h2).SetNext(h3);
h1.Handle(2);

sealed class Handler
{
    private readonly int _level;
    private Handler? _next;
    public Handler(int level) => _level = level;

    public Handler SetNext(Handler next)
    {
        _next = next;
        return next;
    }

    public void Handle(int level)
    {
        if (level == _level)
            Console.WriteLine($"handled by {_level}");
        else
            _next?.Handle(level);
    }
}
