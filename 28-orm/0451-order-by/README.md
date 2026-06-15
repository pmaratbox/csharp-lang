# 0451 — Order by

Sort results by a column. This lesson uses Entity Framework Core (`Microsoft.EntityFrameworkCore.Sqlite`) over an in-memory SQLite connection. A `User` entity maps to the `Users` `DbSet`; after `EnsureCreated()` seeds three rows via `AddRange`/`SaveChanges`, the query `db.Users.OrderBy(u => u.Age)` (a LINQ query-builder call translated to `ORDER BY age`) returns the users sorted by age ascending, and each name is printed.

## Run

    dotnet run
