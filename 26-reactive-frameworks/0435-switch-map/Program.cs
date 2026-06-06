using System.Reactive.Linq;
using Microsoft.Reactive.Testing;

var scheduler = new TestScheduler();

// outer emits 1@10, 2@20
var outer = Observable.Merge(
    Observable.Return(1).Delay(TimeSpan.FromTicks(10), scheduler),
    Observable.Return(2).Delay(TimeSpan.FromTicks(20), scheduler));

// inner(n) emits n at +5 and n*10 at +30
IObservable<int> Inner(int n) => Observable.Merge(
    Observable.Return(n).Delay(TimeSpan.FromTicks(5), scheduler),
    Observable.Return(n * 10).Delay(TimeSpan.FromTicks(30), scheduler));

// switchMap: a new outer value cancels the previous inner stream
var results = new List<int>();
outer.Select(Inner).Switch().Subscribe(v => results.Add(v));

scheduler.Start();

foreach (var v in results)
    Console.WriteLine(v);
