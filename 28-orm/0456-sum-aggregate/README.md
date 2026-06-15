# 0456 — Sum aggregate

Define a `User` entity (id, name, age) with Entity Framework Core over an in-memory SQLite database, insert three rows, then compute the total age with the LINQ `Sum` aggregate (`db.Users.Sum(u => u.Age)`), which EF Core translates to a SQL `SUM(age)` query. Uses the Microsoft.EntityFrameworkCore.Sqlite provider with a `DbContext` and `DbSet<User>`.

## Run

    dotnet run
