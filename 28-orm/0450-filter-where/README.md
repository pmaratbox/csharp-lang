# 0450 — Filter with where

Query rows matching a condition with Entity Framework Core over an in-memory SQLite database. The `User` entity is mapped by a `DbContext`, the schema is created with `EnsureCreated`, and rows are queried through LINQ's `Where` operator (`u.Age >= 30`) combined with `OrderBy` for deterministic ordering. Each matching name is printed.

## Run

    dotnet run
