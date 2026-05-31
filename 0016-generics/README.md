# 0016 — Generics

Define a generic `first` function that returns the first element of a list, then
call it on a list of integers and a list of strings to show one definition
working at two types. C# writes the type parameter after the method name as
`T First<T>(IReadOnlyList<T> items)`, and infers `T` from the argument so each
call needs no explicit type argument. Unlike Java's erasure, C# generics are
*reified* — `T` survives to runtime as a real type, and value types like `int`
are specialized without boxing. With top-level statements the local generic
function sits below the code that calls it.

## Run

    dotnet run
