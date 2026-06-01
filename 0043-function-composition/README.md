# 0043 — Function Composition

Compose `inc` (add one) and `twice` (multiply by two) into one function and apply it to `3`, so `inc(twice(3))` prints `7`. `compose` takes two `Func<int, int>` delegates and returns a lambda `x => f(g(x))`. Delegates are first-class, so the composed function is just another value to return and call.

## Run

    dotnet run
