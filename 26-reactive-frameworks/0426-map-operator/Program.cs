using System.Reactive.Concurrency;
using System.Reactive.Linq;

new[] { 1, 2, 3, 4 }
    .ToObservable(Scheduler.Immediate)
    .Select(x => x * 2)
    .Subscribe(v => Console.WriteLine(v));
