using System.Globalization;

// A virtual-time scheduler: a priority queue of (time, insertion-seq, callback).
// schedule(t, cb) enqueues; cancel marks a token dead; run() pops the smallest
// (time, seq), skips cancelled ones, advances the clock and invokes the callback.
var scheduler = new Scheduler();

// debounce(window): on each value, cancel any pending emit and schedule this
// value to fire at now+window. Only a value that survives a quiet gap fires.
void Debounce(Source<string> source, long window, Action<string> onNext)
{
    Token? pending = null;
    source.Subscribe(
        onNext: value =>
        {
            if (pending is not null) scheduler.Cancel(pending);
            pending = scheduler.Schedule(scheduler.Now + window, () => onNext(value));
        });
}

// Source schedules ("a"@10),("b"@20),("c"@100); window=30.
var src = new Source<string>(scheduler, new[]
{
    (10L, "a"),
    (20L, "b"),
    (100L, "c"),
});

Debounce(src, window: 30, onNext: v => Console.WriteLine(v.ToString(CultureInfo.InvariantCulture)));

src.Start();
scheduler.Run();

// --- declarations (must follow all top-level statements) ---

sealed class Token
{
    public bool Cancelled;
}

sealed class Scheduler
{
    private readonly PriorityQueue<(Token token, Action cb), (long time, long seq)> _queue = new();
    private long _seq;
    public long Now { get; private set; }

    public Token Schedule(long time, Action cb)
    {
        var token = new Token();
        _queue.Enqueue((token, cb), (time, _seq++));
        return token;
    }

    public void Cancel(Token token) => token.Cancelled = true;

    public void Run()
    {
        while (_queue.TryDequeue(out var item, out var priority))
        {
            if (item.token.Cancelled) continue;
            Now = priority.time;
            item.cb();
        }
    }
}

sealed class Source<T>
{
    private readonly Scheduler _scheduler;
    private readonly (long time, T value)[] _events;
    private Action<T>? _onNext;

    public Source(Scheduler scheduler, (long, T)[] events)
    {
        _scheduler = scheduler;
        _events = events;
    }

    public void Subscribe(Action<T> onNext) => _onNext = onNext;

    public void Start()
    {
        foreach (var (time, value) in _events)
            _scheduler.Schedule(time, () => _onNext?.Invoke(value));
    }
}
