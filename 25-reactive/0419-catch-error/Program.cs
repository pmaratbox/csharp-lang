// catchError: on an error from the source, switch to a fallback stream.

static Observable<int> CatchError(Observable<int> source, Observable<int> fallback) =>
    new Observable<int>(observer =>
        source.Subscribe(new Observer<int>(
            onNext: observer.OnNext,
            onError: _ => fallback.Subscribe(observer),
            onCompleted: observer.OnCompleted)));

var source = new Observable<int>(observer =>
{
    observer.OnNext(1);
    observer.OnNext(2);
    observer.OnError(new Exception("boom"));
});

var fallback = new Observable<int>(observer =>
{
    observer.OnNext(9);
    observer.OnCompleted();
});

CatchError(source, fallback).Subscribe(new Observer<int>(
    onNext: v => Console.WriteLine(v),
    onError: _ => { },
    onCompleted: () => { }));

sealed class Observer<T>(Action<T> onNext, Action<Exception> onError, Action onCompleted)
{
    public void OnNext(T value) => onNext(value);
    public void OnError(Exception error) => onError(error);
    public void OnCompleted() => onCompleted();
}

sealed class Observable<T>(Action<Observer<T>> subscribe)
{
    public void Subscribe(Observer<T> observer) => subscribe(observer);
}
