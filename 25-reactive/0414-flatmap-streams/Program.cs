using System.Globalization;

// Virtual-time scheduler: deterministic, no real time/threads/randomness.
var scheduler = new Scheduler();

// flatMap/mergeMap: map each outer value to an inner timed stream and merge
// all inners concurrently (no cancellation).
//
// Outer schedules (10 -> 1), (20 -> 2).
// For each outer value n, the inner schedules (now+5 -> n) and (now+30 -> n*10).
// All inners run concurrently => timeline: 15->1, 25->2, 40->10, 50->20.

var outer = new Observable<int>(obs =>
{
    scheduler.Schedule(10, () => obs.Next(1));
    scheduler.Schedule(20, () => obs.Next(2));
});

Observable<int> FlatMap(Observable<int> source, Func<int, Observable<int>> project) =>
    new Observable<int>(obs =>
    {
        source.Subscribe(new Observer<int>(
            onNext: n => project(n).Subscribe(obs),
            onError: obs.Error,
            onComplete: () => { }));
    });

var merged = FlatMap(outer, n => new Observable<int>(obs =>
{
    var now = scheduler.Now;
    scheduler.Schedule(now + 5, () => obs.Next(n));
    scheduler.Schedule(now + 30, () => obs.Next(n * 10));
}));

merged.Subscribe(new Observer<int>(
    onNext: v => Console.WriteLine(v.ToString(CultureInfo.InvariantCulture)),
    onError: _ => { },
    onComplete: () => { }));

scheduler.Run();

// ---- from-scratch reactive primitives ----

sealed class Observer<T>
{
    private readonly Action<T> _onNext;
    private readonly Action<Exception> _onError;
    private readonly Action _onComplete;

    public Observer(Action<T> onNext, Action<Exception> onError, Action onComplete)
    {
        _onNext = onNext;
        _onError = onError;
        _onComplete = onComplete;
    }

    public void Next(T value) => _onNext(value);
    public void Error(Exception ex) => _onError(ex);
    public void Complete() => _onComplete();
}

sealed class Observable<T>
{
    private readonly Action<Observer<T>> _subscribe;
    public Observable(Action<Observer<T>> subscribe) => _subscribe = subscribe;
    public void Subscribe(Observer<T> observer) => _subscribe(observer);
}

sealed class Scheduler
{
    private readonly PriorityQueue<Action, (long Time, long Seq)> _queue = new();
    private long _seq;
    public long Now { get; private set; }

    public void Schedule(long time, Action callback)
        => _queue.Enqueue(callback, (time, _seq++));

    public void Run()
    {
        while (_queue.TryDequeue(out var callback, out var key))
        {
            Now = key.Time;
            callback();
        }
    }
}
