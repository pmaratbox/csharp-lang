// A transducer transforms a reducing step into a new reducing step.
static Func<Func<R, int, R>, Func<R, int, R>> Mapping<R>(Func<int, int> f) =>
    step => (acc, x) => step(acc, f(x));

static Func<Func<R, int, R>, Func<R, int, R>> Filtering<R>(Func<int, bool> p) =>
    step => (acc, x) => p(x) ? step(acc, x) : acc;

var mapInc = Mapping<List<int>>(x => x + 1);
var keepEven = Filtering<List<int>>(x => x % 2 == 0);

Func<List<int>, int, List<int>> append = (acc, x) => { acc.Add(x); return acc; };

// Compose: map(+1) then filter(even). Transducers compose left-to-right in data order.
var xf = mapInc(keepEven(append));

var result = new[] { 1, 2, 3, 4 }.Aggregate(new List<int>(), xf);

Console.WriteLine(string.Join(' ', result));
