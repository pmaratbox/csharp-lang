# 0017 — Iterators

Take the numbers 1 through 5, keep the even ones, double each, and add them up —
a filter, then a map, then a reduce — printing the final sum. C# expresses the
pipeline with LINQ: `Where` is the filter, `Select` is the map, and `Sum` is the
reduce. These are lazy extension methods on `IEnumerable<T>` that build a
deferred query, and the terminal `Sum()` is what actually pulls the elements
through and drives the iteration.

## Run

    dotnet run
