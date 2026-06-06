using System.Reactive.Linq;

new[] { 1, 2, 3 }
    .ToObservable(System.Reactive.Concurrency.Scheduler.Immediate)
    .Subscribe(
        onNext: v => Console.WriteLine(v),
        onCompleted: () => Console.WriteLine("done"));
