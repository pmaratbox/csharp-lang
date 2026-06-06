using System.Reactive.Concurrency;
using System.Reactive.Linq;

var first = new[] { 1, 2 }.ToObservable(Scheduler.Immediate);
var second = new[] { 3, 4 }.ToObservable(Scheduler.Immediate);

first.Concat(second).Subscribe(v => Console.WriteLine(v));
