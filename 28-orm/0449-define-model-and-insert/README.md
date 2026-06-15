# 0449 — Define model & insert

Define a `User` entity (`id`, `name`, `age`) and map it with Entity Framework Core's `DbContext`/`DbSet<User>` over an in-memory SQLite database. The schema is created from the model via `Database.EnsureCreated()`, rows are inserted with `AddRange` + `SaveChanges`, and read back with a LINQ `OrderBy(u => u.Id)` query before printing each name. Uses Microsoft.EntityFrameworkCore.Sqlite with a shared open `SqliteConnection` so the in-memory database survives.

## Run

    dotnet run
