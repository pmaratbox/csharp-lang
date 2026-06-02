# 0044 — Generic Constraints

Write a generic `largest(a, b)` that requires an ordered type, then call it on integers (3 and 9) and on strings (apple and pear), printing `9` and `pear`. The constraint `where T : IComparable<T>` requires `T` to implement comparison, making `CompareTo` available. C# also supports other constraint kinds — `class`, `struct`, `new()`, and interfaces.

## Run

    dotnet run
