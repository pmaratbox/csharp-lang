var bLens = new Lens<Inner, int>(i => i.B, (i, v) => i with { B = v });
var aLens = new Lens<Outer, Inner>(o => o.A, (o, v) => o with { A = v });

var compose = new Lens<Outer, int>(
    o => bLens.Get(aLens.Get(o)),
    (o, v) => aLens.Set(o, bLens.Set(aLens.Get(o), v)));

var data = new Outer(new Inner(1));
var got = compose.Get(data);
var updated = compose.Set(data, 2);

Console.WriteLine($"{got} {compose.Get(updated)}");

record Inner(int B);
record Outer(Inner A);
record Lens<S, A>(Func<S, A> Get, Func<S, A, S> Set);
