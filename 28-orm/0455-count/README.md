# 0455 — Count

Count all rows in a `users` table using Entity Framework Core over an in-memory SQLite database. A `User` entity and `AppDb : DbContext` define the model-driven schema (`EnsureCreated`), three rows are inserted via `AddRange`/`SaveChanges`, and the row count is obtained with the LINQ `Count()` aggregate on the `DbSet<User>` (EF Core translates it to `SELECT COUNT(*)`). Uses Microsoft.EntityFrameworkCore.Sqlite.

## Run

    dotnet run
