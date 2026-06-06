// Return a Subscription from subscribe() and use it to unsubscribe so later
// values are not delivered. The producer checks the subscription's Closed flag
// before each push and stops once the consumer unsubscribes.

var source = new Observable<int>(observer =>
{
    foreach (var value in new[] { 1, 2, 3, 4 })
    {
        if (observer.Closed) return;
        observer.Next(value);
    }
});

// The callback receives its own Subscription so it can unsubscribe mid-stream.
source.Subscribe((value, subscription) =>
{
    Console.WriteLine(value);
    if (value == 2) subscription.Unsubscribe();
});

// A subscription handed to the producer; toggling Closed stops delivery.
sealed class Subscription
{
    public bool Closed { get; private set; }
    public void Unsubscribe() => Closed = true;
}

// Bridges the consumer callback with the closed flag the producer reads.
sealed class Observer<T>
{
    private readonly Action<T, Subscription> _onNext;
    private readonly Subscription _subscription;

    public Observer(Action<T, Subscription> onNext, Subscription subscription)
    {
        _onNext = onNext;
        _subscription = subscription;
    }

    public bool Closed => _subscription.Closed;
    public void Next(T value) => _onNext(value, _subscription);
}

// A from-scratch push-based Observable: subscribe wires a producer to a consumer.
sealed class Observable<T>
{
    private readonly Action<Observer<T>> _produce;

    public Observable(Action<Observer<T>> produce) => _produce = produce;

    public Subscription Subscribe(Action<T, Subscription> onNext)
    {
        var subscription = new Subscription();
        _produce(new Observer<T>(onNext, subscription));
        return subscription;
    }
}
