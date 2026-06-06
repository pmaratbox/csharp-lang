using System.Globalization;

// Virtual-time scheduler: priority queue of (time, insertion-seq, callback).
var scheduler = new Scheduler();

// Two timed integer sources.
var a = Source(scheduler, new (int Time, int Value)[] { (1, 1), (3, 2) });
var b = Source(scheduler, new (int Time, int Value)[] { (2, 10) });

// combineLatest: emit the pair of latest values whenever either source emits,
// once both have emitted at least once.
CombineLatest(a, b).Subscribe(new Observer<(int, int)>(
    onNext: pair => Console.WriteLine(
        string.Format(CultureInfo.InvariantCulture, "({0}, {1})", pair.Item1, pair.Item2)),
    onComplete: () => { }));

scheduler.Run();

// Builds an Observable that schedules each (time, value) emission on the scheduler.
static Observable<int> Source(Scheduler scheduler, (int Time, int Value)[] events) =>
    new Observable<int>(observer =>
    {
        foreach (var ev in events)
            scheduler.Schedule(ev.Time, () => observer.OnNext(ev.Value));
    });

static Observable<(T1, T2)> CombineLatest<T1, T2>(Observable<T1> s1, Observable<T2> s2) =>
    new Observable<(T1, T2)>(observer =>
    {
        var has1 = false;
        var has2 = false;
        T1 latest1 = default!;
        T2 latest2 = default!;

        void Emit()
        {
            if (has1 && has2)
                observer.OnNext((latest1, latest2));
        }

        s1.Subscribe(new Observer<T1>(v => { latest1 = v; has1 = true; Emit(); }, () => { }));
        s2.Subscribe(new Observer<T2>(v => { latest2 = v; has2 = true; Emit(); }, () => { }));
    });

sealed class Observer<T>
{
    private readonly Action<T> _onNext;
    private readonly Action _onComplete;

    public Observer(Action<T> onNext, Action onComplete)
    {
        _onNext = onNext;
        _onComplete = onComplete;
    }

    public void OnNext(T value) => _onNext(value);
    public void OnComplete() => _onComplete();
}

sealed class Observable<T>
{
    private readonly Action<Observer<T>> _subscribe;
    public Observable(Action<Observer<T>> subscribe) => _subscribe = subscribe;
    public void Subscribe(Observer<T> observer) => _subscribe(observer);
}

sealed class Scheduler
{
    private readonly PriorityQueue<Action, (int Time, int Seq)> _queue = new();
    private int _seq;

    public void Schedule(int time, Action callback) =>
        _queue.Enqueue(callback, (time, _seq++));

    public void Run()
    {
        while (_queue.Count > 0)
            _queue.Dequeue()();
    }
}
