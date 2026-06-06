// BehaviorSubject: holds a current value and replays it immediately to each
// new subscriber. Built from scratch — no System.IObservable / System.Reactive.

var subject = new BehaviorSubject<int>(0);

var a = subject.Subscribe(v => Console.WriteLine($"A: {v}"));
subject.Next(1);
var b = subject.Subscribe(v => Console.WriteLine($"B: {v}"));
subject.Next(2);

a.Dispose();
b.Dispose();

// A minimal from-scratch BehaviorSubject. Observers are plain closures; the
// subject stores the latest value and replays it on subscribe.
sealed class BehaviorSubject<T>
{
    private T _current;
    private readonly List<Action<T>> _observers = new();

    public BehaviorSubject(T initial) => _current = initial;

    public IDisposable Subscribe(Action<T> onNext)
    {
        _observers.Add(onNext);
        onNext(_current); // replay current value immediately
        return new Subscription(() => _observers.Remove(onNext));
    }

    public void Next(T value)
    {
        _current = value;
        foreach (var obs in _observers.ToArray())
            obs(value);
    }

    private sealed class Subscription : IDisposable
    {
        private Action? _dispose;
        public Subscription(Action dispose) => _dispose = dispose;
        public void Dispose()
        {
            _dispose?.Invoke();
            _dispose = null;
        }
    }
}
