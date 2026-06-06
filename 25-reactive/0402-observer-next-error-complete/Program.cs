using System.Globalization;

// Observer contract: next* then a single terminal (complete or error).
// A "stopped" flag guards against any delivery after the terminal.
var observer = new SafeObserver(
    onNext: v => Console.WriteLine(v.ToString(CultureInfo.InvariantCulture)),
    onError: _ => Console.WriteLine("error"),
    onComplete: () => Console.WriteLine("complete"));

observer.Next(1);
observer.Next(2);
observer.Complete();
observer.Next(3); // ignored: observer already stopped

sealed class SafeObserver
{
    private readonly Action<int> _onNext;
    private readonly Action<Exception> _onError;
    private readonly Action _onComplete;
    private bool _stopped;

    public SafeObserver(Action<int> onNext, Action<Exception> onError, Action onComplete)
    {
        _onNext = onNext;
        _onError = onError;
        _onComplete = onComplete;
    }

    public void Next(int value)
    {
        if (_stopped) return;
        _onNext(value);
    }

    public void Error(Exception ex)
    {
        if (_stopped) return;
        _stopped = true;
        _onError(ex);
    }

    public void Complete()
    {
        if (_stopped) return;
        _stopped = true;
        _onComplete();
    }
}
