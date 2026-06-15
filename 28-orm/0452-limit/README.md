# 0452 — Limit

Take only the top N rows. This lesson uses Entity Framework Core with the `Microsoft.EntityFrameworkCore.Sqlite` provider over an in-memory SQLite database. A `User` entity is mapped via a `DbContext`, three rows are inserted with `AddRange`/`SaveChanges`, and the LINQ query builder composes `OrderByDescending(u => u.Age).Take(2)` to translate into a SQL `ORDER BY age DESC LIMIT 2`, printing each name.

## Run

    dotnet run
