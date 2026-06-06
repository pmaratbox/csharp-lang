// ReplaySubject: a hot source that buffers the last N values and replays them
// to any late subscriber before forwarding subsequent emissions.

var subject = new ReplaySubject<int>(bufferSize: 2);

// Early emissions with no subscribers; buffer keeps the last 2 -> [2, 3].
subject.OnNext(1);
subject.OnNext(2);
subject.OnNext(3);

// Late subscriber immediately receives the buffered 2 then 3.
subject.Subscribe(value => Console.WriteLine(value));

// New emission is forwarded live to the subscriber.
subject.OnNext(4);

// An observer is just a callback; subscribe wires it to the producer.
sealed class ReplaySubject<T>
{
    private readonly int _bufferSize;
    private readonly Queue<T> _buffer = new();
    private readonly List<Action<T>> _observers = new();

    public ReplaySubject(int bufferSize) => _bufferSize = bufferSize;

    public void Subscribe(Action<T> onNext)
    {
        _observers.Add(onNext);
        foreach (var value in _buffer)
            onNext(value);
    }

    public void OnNext(T value)
    {
        _buffer.Enqueue(value);
        while (_buffer.Count > _bufferSize)
            _buffer.Dequeue();

        foreach (var observer in _observers)
            observer(value);
    }
}
