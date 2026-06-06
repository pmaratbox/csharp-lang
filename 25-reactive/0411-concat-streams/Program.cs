// Concat: subscribe to the second source only after the first completes.
// A from-scratch push-based Observable (no System.Reactive). Fully synchronous.

var a = ConcatStreams.FromValues(1, 2);
var b = ConcatStreams.FromValues(3, 4);

ConcatStreams.Concat(a, b).Subscribe(new Observer<int>(
    onNext: x => Console.WriteLine(x),
    onComplete: () => { }));

// An observer is just a triple of callbacks: next / error / complete.
sealed class Observer<T>
{
    private readonly Action<T> _onNext;
    private readonly Action _onComplete;

    public Observer(Action<T> onNext, Action onComplete)
    {
        _onNext = onNext;
        _onComplete = onComplete;
    }

    public void Next(T value) => _onNext(value);
    public void Complete() => _onComplete();
}

// An Observable is a producer: subscribe wires it to an observer.
sealed class Observable<T>
{
    private readonly Action<Observer<T>> _subscribe;

    public Observable(Action<Observer<T>> subscribe) => _subscribe = subscribe;

    public void Subscribe(Observer<T> observer) => _subscribe(observer);
}

static class ConcatStreams
{
    public static Observable<T> FromValues<T>(params T[] values) =>
        new Observable<T>(obs =>
        {
            foreach (var v in values) obs.Next(v);
            obs.Complete();
        });

    // Subscribe to a; on a.complete, subscribe to b; on b.complete, complete.
    public static Observable<T> Concat<T>(Observable<T> a, Observable<T> b) =>
        new Observable<T>(downstream =>
        {
            a.Subscribe(new Observer<T>(
                onNext: downstream.Next,
                onComplete: () => b.Subscribe(new Observer<T>(
                    onNext: downstream.Next,
                    onComplete: downstream.Complete))));
        });
}
