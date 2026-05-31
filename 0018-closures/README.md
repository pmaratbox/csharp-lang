# 0018 — Closures

Build a counter that captures a private count starting at zero; each call to the
returned function increments the count and returns it, so calling it twice prints
1 then 2. C# closures capture variables by reference, not by value, so the lambda
`() => ++count` reassigns the very same `count` local and the compiler lifts it
onto a heap-allocated closure object that outlives `Counter`. The returned
delegate has type `Func<int>` (a parameterless function returning an `int`), and
each call to `Counter` builds a fresh, independent `count`.

## Run

    dotnet run
