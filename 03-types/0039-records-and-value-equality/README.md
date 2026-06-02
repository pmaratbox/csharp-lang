# 0039 — Records & Value Equality

Create two points with the same fields, print one as `point: (1, 2)`, and compare them by value to print `equal: yes`. A positional `record` synthesizes value-based `Equals`, `GetHashCode`, `ToString`, and an `==` that compares by value (records override the usual reference `==`). `with` expressions make modified copies.

## Run

    dotnet run
