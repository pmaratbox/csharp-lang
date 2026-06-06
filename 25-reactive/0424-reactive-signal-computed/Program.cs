// Fine-grained reactivity built from scratch: a writable Signal and a derived Computed.
// A Signal holds a value plus a list of subscriber callbacks; writing notifies them.
// A Computed registers its recompute as a subscriber of every Signal it reads, and
// caches the result until a dependency changes.

var a = new Signal<int>(2);
var b = new Signal<int>(3);

var sum = new Computed<int>(() => a.Get() + b.Get(), a, b);

Console.WriteLine(sum.Get()); // 5

a.Set(10);                     // notifies subscribers -> sum recomputes

Console.WriteLine(sum.Get()); // 13

interface IReactive
{
    void Subscribe(Action callback);
}

sealed class Signal<T> : IReactive
{
    private T _value;
    private readonly List<Action> _subscribers = new();

    public Signal(T value) => _value = value;

    public T Get() => _value;

    public void Set(T value)
    {
        _value = value;
        foreach (var s in _subscribers.ToArray())
            s();
    }

    public void Subscribe(Action callback) => _subscribers.Add(callback);
}

sealed class Computed<T>
{
    private readonly Func<T> _compute;
    private T _cached;
    private bool _dirty = true;

    public Computed(Func<T> compute, params IReactive[] deps)
    {
        _compute = compute;
        _cached = default!;
        foreach (var dep in deps)
            dep.Subscribe(() => _dirty = true);
    }

    public T Get()
    {
        if (_dirty)
        {
            _cached = _compute();
            _dirty = false;
        }
        return _cached;
    }
}
