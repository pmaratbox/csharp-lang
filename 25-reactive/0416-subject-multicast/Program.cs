var subject = new Subject<int>();

subject.Subscribe(v => Console.WriteLine($"obs1: {v}"));
subject.Subscribe(v => Console.WriteLine($"obs2: {v}"));

subject.Next(1);
subject.Next(2);

sealed class Subject<T>
{
    private readonly List<Action<T>> _observers = new();

    public void Subscribe(Action<T> observer) => _observers.Add(observer);

    public void Next(T value)
    {
        foreach (var observer in _observers)
            observer(value);
    }
}
