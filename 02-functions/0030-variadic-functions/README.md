# 0030 — Variadic Functions

Define a function that accepts a variable number of integer arguments and returns their total, then call it with `1, 2, 3` to print `sum: 6`. A `params int[] nums` parameter lets the caller pass any number of `int`s, which the compiler collects into an array (here summed with LINQ's `Sum`). An existing array can be passed in its place.

## Run

    dotnet run
