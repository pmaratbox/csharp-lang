using System.Globalization;

// A push-based Observable built from scratch: subscribe wires a producer to an
// observer (next/error/complete closures). scan keeps running state seeded with
// acc and emits f(state, value) for every incoming value.

var source = Observable<int>.FromValues(1, 2, 3, 4);
var running = source.Scan(0, (state, value) => state + value);

running.Subscribe(
    onNext: v => Console.WriteLine(v.ToString(CultureInfo.InvariantCulture)),
    onComplete: () => { });

sealed class Observable<T>
{
    private readonly Action<Observer<T>> _subscribe;

    private Observable(Action<Observer<T>> subscribe) => _subscribe = subscribe;

    public void Subscribe(Action<T> onNext, Action onComplete)
        => _subscribe(new Observer<T>(onNext, onComplete));

    public static Observable<T> FromValues(params T[] values) =>
        new(observer =>
        {
            foreach (var value in values)
                observer.OnNext(value);
            observer.OnComplete();
        });

    public Observable<TResult> Scan<TResult>(TResult seed, Func<TResult, T, TResult> f) =>
        new(observer =>
        {
            var state = seed;
            Subscribe(
                value =>
                {
                    state = f(state, value);
                    observer.OnNext(state);
                },
                observer.OnComplete);
        });
}

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
