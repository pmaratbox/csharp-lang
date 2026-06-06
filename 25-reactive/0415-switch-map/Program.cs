using System.Globalization;

// Virtual-time scheduler: a priority queue of (time, insertion-seq, callback).
var scheduler = new Scheduler();

// switchMap: when a new outer value arrives, cancel the previous inner
// subscription's still-pending scheduled emissions before starting the new one.
var observer = new Observer<int>(
    onNext: v => Console.WriteLine(v.ToString(CultureInfo.InvariantCulture)),
    onComplete: () => { });

// inner(n): schedules (now+5 -> n), (now+30 -> n*10).
// Returns a cancellation token list for its pending emissions.
List<int> Inner(int n)
{
    var tokens = new List<int>();
    long now = scheduler.Now;
    tokens.Add(scheduler.Schedule(now + 5, () => observer.OnNext(n)));
    tokens.Add(scheduler.Schedule(now + 30, () => observer.OnNext(n * 10)));
    return tokens;
}

List<int>? current = null;

void OnOuter(int n)
{
    // cancel the previous inner's still-pending scheduled emissions
    if (current != null)
        foreach (var t in current)
            scheduler.Cancel(t);
    current = Inner(n);
}

// outer (10 -> 1), (20 -> 2)
scheduler.Schedule(10, () => OnOuter(1));
scheduler.Schedule(20, () => OnOuter(2));

scheduler.Run();

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

sealed class Scheduler
{
    private readonly PriorityQueue<int, (long time, long seq)> _queue = new();
    private readonly Dictionary<int, Action> _actions = new();
    private readonly HashSet<int> _cancelled = new();
    private long _seq;
    private int _nextToken;
    public long Now { get; private set; }

    public int Schedule(long time, Action callback)
    {
        int token = _nextToken++;
        _actions[token] = callback;
        _queue.Enqueue(token, (time, _seq++));
        return token;
    }

    public void Cancel(int token) => _cancelled.Add(token);

    public void Run()
    {
        while (_queue.TryDequeue(out int token, out var key))
        {
            if (_cancelled.Contains(token)) continue;
            Now = key.time;
            _actions[token]();
        }
    }
}
