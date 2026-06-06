using System.Reactive.Concurrency;
using System.Reactive.Linq;

var first = new[] { 1, 2, 3 }.ToObservable(Scheduler.Immediate);
var second = new[] { 10, 20, 30 }.ToObservable(Scheduler.Immediate);

first.Zip(second, (a, b) => a + b).Subscribe(v => Console.WriteLine(v));
