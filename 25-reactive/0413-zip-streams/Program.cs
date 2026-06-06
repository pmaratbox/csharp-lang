// 0413 — Zip Streams
// A from-scratch push-based Observable. zip pairs values by index and
// combines them: buffer each source, and whenever both buffers are
// non-empty, dequeue one from each and emit combine(x, y).

var a = Observable<int>.FromValues(1, 2, 3);
var b = Observable<int>.FromValues(10, 20, 30);

var zipped = Observable<int>.Zip(a, b, (x, y) => x + y);

zipped.Subscribe(new Observer<int>(
    onNext: v => Console.WriteLine(v),
    onError: e => Console.Error.WriteLine(e.Message),
    onCompleted: () => { }));

// An observer is just a triple of callbacks.
sealed class Observer<T>
{
    public Action<T> OnNext { get; }
    public Action<Exception> OnError { get; }
    public Action OnCompleted { get; }

    public Observer(Action<T> onNext, Action<Exception> onError, Action onCompleted)
    {
        OnNext = onNext;
        OnError = onError;
        OnCompleted = onCompleted;
    }
}

// An Observable is a producer: subscribe wires it to an observer.
sealed class Observable<T>
{
    private readonly Action<Observer<T>> _subscribe;

    private Observable(Action<Observer<T>> subscribe) => _subscribe = subscribe;

    public void Subscribe(Observer<T> observer) => _subscribe(observer);

    public static Observable<T> FromValues(params T[] values) =>
        new Observable<T>(obs =>
        {
            foreach (var v in values) obs.OnNext(v);
            obs.OnCompleted();
        });

    public static Observable<TResult> Zip<TA, TB, TResult>(
        Observable<TA> a, Observable<TB> b, Func<TA, TB, TResult> combine) =>
        new Observable<TResult>(obs =>
        {
            var qa = new Queue<TA>();
            var qb = new Queue<TB>();
            var aDone = false;
            var bDone = false;

            void Pump()
            {
                while (qa.Count > 0 && qb.Count > 0)
                    obs.OnNext(combine(qa.Dequeue(), qb.Dequeue()));
            }

            a.Subscribe(new Observer<TA>(
                onNext: x => { qa.Enqueue(x); Pump(); },
                onError: obs.OnError,
                onCompleted: () => { aDone = true; if (aDone && bDone) obs.OnCompleted(); }));

            b.Subscribe(new Observer<TB>(
                onNext: y => { qb.Enqueue(y); Pump(); },
                onError: obs.OnError,
                onCompleted: () => { bDone = true; if (aDone && bDone) obs.OnCompleted(); }));
        });
}
