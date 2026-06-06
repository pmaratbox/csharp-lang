using System.Globalization;

// Virtual-time scheduler: a priority queue of (time, insertion-seq, callback).
var scheduler = new Scheduler();

// A source that schedules its emissions at the given virtual times.
var source = new Observable<string>(observer =>
{
    scheduler.Schedule(10, () => observer.Next("a"));
    scheduler.Schedule(20, () => observer.Next("b"));
    scheduler.Schedule(100, () => observer.Next("c"));
    scheduler.Schedule(110, () => observer.Next("d"));
});

// throttle(window): leading edge. Emit a value, then suppress for `window` ticks.
static Observable<T> Throttle<T>(Observable<T> src, Scheduler sched, long window) =>
    new Observable<T>(downstream =>
    {
        long blockUntil = 0;
        src.Subscribe(new Observer<T>(value =>
        {
            if (sched.Now >= blockUntil)
            {
                blockUntil = sched.Now + window;
                downstream.Next(value);
            }
        }));
    });

Throttle(source, scheduler, 30).Subscribe(new Observer<string>(v =>
    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "{0}", v))));

scheduler.Run();

// ---- declarations after top-level statements ----

sealed class Observer<T>
{
    private readonly Action<T> _next;
    public Observer(Action<T> next) => _next = next;
    public void Next(T value) => _next(value);
}

sealed class Observable<T>
{
    private readonly Action<Observer<T>> _subscribe;
    public Observable(Action<Observer<T>> subscribe) => _subscribe = subscribe;
    public void Subscribe(Observer<T> observer) => _subscribe(observer);
}

sealed class Scheduler
{
    private readonly PriorityQueue<(long Time, long Seq, Action Cb), (long, long)> _queue = new();
    private long _seq;
    public long Now { get; private set; }

    public void Schedule(long time, Action cb)
    {
        var seq = _seq++;
        _queue.Enqueue((time, seq, cb), (time, seq));
    }

    public void Run()
    {
        while (_queue.Count > 0)
        {
            var item = _queue.Dequeue();
            Now = item.Time;
            item.Cb();
        }
    }
}
