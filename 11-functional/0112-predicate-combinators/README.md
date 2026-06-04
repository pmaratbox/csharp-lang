# 0112 — Predicate Combinators

Combine predicates with AND/OR/NOT: test `isEven AND isPositive` on 4 (yes) and -4 (no), printing `yes no`. The `And` combinator takes two `Func<int, bool>` predicates and returns a new one that short-circuits with `&&`.

## Run

    dotnet run
