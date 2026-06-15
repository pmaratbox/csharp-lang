# 0532 — Update an element

Use `System.Collections.Immutable`'s `ImmutableList<T>`. Calling `SetItem(0, 99)` does not mutate the list in place; it returns a brand new `ImmutableList` with index `0` replaced, while the original list stays unchanged. Printing both shows `99 2 3` for the updated list and the untouched `1 2 3` for the original.

## Run

    dotnet run
