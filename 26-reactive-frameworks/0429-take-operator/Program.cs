using System.Reactive.Linq;

// Unbounded source of naturals 1, 2, 3, ... The default (CurrentThread)
// scheduler keeps emission synchronous and deterministic while still
// honouring Take's unsubscription so the loop terminates cleanly.
IObservable<int> naturals = Observable.Generate(
    initialState: 1,
    condition: _ => true,
    iterate: x => x + 1,
    resultSelector: x => x);

naturals
    .Take(3)
    .Subscribe(
        onNext: v => Console.WriteLine(v),
        onCompleted: () => Console.WriteLine("completed"));
