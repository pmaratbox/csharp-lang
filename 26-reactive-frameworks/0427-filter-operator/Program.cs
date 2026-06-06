using System.Reactive.Concurrency;
using System.Reactive.Linq;

new[] { 1, 2, 3, 4, 5, 6 }
    .ToObservable(Scheduler.Immediate)
    .Where(x => x % 2 == 0)
    .Subscribe(v => Console.WriteLine(v));
