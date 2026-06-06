using System.Reactive.Concurrency;
using System.Reactive.Linq;

new[] { 1, 2, 3, 4 }
    .ToObservable(Scheduler.Immediate)
    .Scan(0, (acc, x) => acc + x)
    .Subscribe(v => Console.WriteLine(v));
