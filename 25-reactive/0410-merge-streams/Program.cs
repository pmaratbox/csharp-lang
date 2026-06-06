using System.Globalization;

// Virtual-time scheduler: a priority queue of (time, insertion-seq, callback).
var scheduler = new Scheduler();

// Build the merged observer that prints each value, one per line.
void OnNext(int value) =>
    Console.WriteLine(value.ToString(CultureInfo.InvariantCulture));

// Stream A schedules values at times (10->1),(30->3),(50->5).
var streamA = Observable.Timed(scheduler, (10, 1), (30, 3), (50, 5));
// Stream B schedules values at times (20->2),(40->4),(60->6).
var streamB = Observable.Timed(scheduler, (20, 2), (40, 4), (60, 6));

// merge subscribes to both onto the same observer.
var merged = Observable.Merge(streamA, streamB);
merged.Subscribe(OnNext);

// Drive everything by running the scheduler once.
scheduler.Run();

// --- declarations below all top-level statements (CS8803) ---

sealed class Scheduler
{
    private readonly PriorityQueue<(long Seq, Action Callback), (long Time, long Seq)> _queue = new();
    private long _seq;
    public long Now { get; private set; }

    public void Schedule(long time, Action callback)
    {
        long seq = _seq++;
        _queue.Enqueue((seq, callback), (time, seq));
    }

    public void Run()
    {
        while (_queue.TryDequeue(out var item, out var key))
        {
            Now = key.Time;
            item.Callback();
        }
    }
}

sealed class Observable
{
    private readonly Action<Action<int>> _subscribe;

    private Observable(Action<Action<int>> subscribe) => _subscribe = subscribe;

    public void Subscribe(Action<int> onNext) => _subscribe(onNext);

    // A source that emits each value by scheduling it at the given virtual time.
    public static Observable Timed(Scheduler scheduler, params (long Time, int Value)[] events) =>
        new(onNext =>
        {
            foreach (var (time, value) in events)
                scheduler.Schedule(time, () => onNext(value));
        });

    // merge: subscribe to all sources onto the same observer.
    public static Observable Merge(params Observable[] sources) =>
        new(onNext =>
        {
            foreach (var source in sources)
                source.Subscribe(onNext);
        });
}
