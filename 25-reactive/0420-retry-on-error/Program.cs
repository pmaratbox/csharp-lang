// From-scratch push-based Observable with a retry(n) operator.
// An Observer is a trio of callbacks (next/error/complete); subscribe wires
// a producer to the observer. retry(n) resubscribes on error up to n times.

var source = new Observable<string>(observer =>
{
    Source.Attempts++;
    int k = Source.Attempts;
    Console.WriteLine($"attempt {k}");
    if (k < 3)
        observer.Error(new Exception($"fail {k}"));
    else
    {
        observer.Next("ok");
        observer.Complete();
    }
});

source.Retry(2).Subscribe(new Observer<string>(
    onNext: v => Console.WriteLine(v),
    onError: _ => { },
    onComplete: () => { }));

static class Source
{
    public static int Attempts;
}

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

    public Observable<T> Retry(int n) => new Observable<T>(observer =>
    {
        void Attempt(int remaining)
        {
            Subscribe(new Observer<T>(
                onNext: observer.Next,
                onError: ex =>
                {
                    if (remaining > 0)
                        Attempt(remaining - 1);
                    else
                        observer.Error(ex);
                },
                onComplete: observer.Complete));
        }
        Attempt(n);
    });
}
