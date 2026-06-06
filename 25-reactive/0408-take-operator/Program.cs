// take(n) over an unbounded source of the natural numbers.
// A from-scratch push-based Observable: subscribe wires a producer to an
// observer (next/complete) and returns a disposable that stops the source.
//
// The source is a synchronous infinite loop, so it registers its teardown with
// the observer BEFORE emitting. That lets take() unsubscribe mid-emission: the
// teardown flips a flag and the loop exits the next time it checks.

var naturals = new Observable<int>(observer =>
{
    var live = true;
    observer.OnSubscribe(() => live = false);
    var n = 0;
    while (live)
    {
        n++;
        observer.OnNext(n);
    }
});

Take(naturals, 3).Subscribe(
    onNext: x => Console.WriteLine(x.ToString(System.Globalization.CultureInfo.InvariantCulture)),
    onComplete: () => Console.WriteLine("completed"));

// take(source, count): forward the first `count` items, then complete and
// unsubscribe so the infinite source stops being driven.
static Observable<int> Take(Observable<int> source, int count) =>
    new(downstream =>
    {
        var taken = 0;
        source.Subscribe(
            onNext: x =>
            {
                if (taken >= count) return;
                taken++;
                downstream.OnNext(x);
                if (taken >= count)
                {
                    downstream.OnComplete(); // emit completion downstream
                    source.Unsubscribe();    // stop the infinite source
                }
            },
            onComplete: downstream.OnComplete);
        // forward downstream teardown so an outer take could cancel us
        downstream.OnSubscribe(source.Unsubscribe);
    });

sealed class Observable<T>(Action<Observer<T>> producer)
{
    private Action _teardown = () => { };

    public void Subscribe(Action<T> onNext, Action? onComplete = null)
    {
        var observer = new Observer<T>(onNext, onComplete, t => _teardown = t);
        producer(observer);
    }

    public void Unsubscribe() => _teardown();
}

sealed class Observer<T>(Action<T> onNext, Action? onComplete, Action<Action> register)
{
    private bool _closed;
    public void OnSubscribe(Action teardown) => register(teardown);
    public void OnNext(T value) { if (!_closed) onNext(value); }
    public void OnComplete() { if (_closed) return; _closed = true; onComplete?.Invoke(); }
}
