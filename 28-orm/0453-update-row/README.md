# 0453 — Update a row

Uses Entity Framework Core (`Microsoft.EntityFrameworkCore.Sqlite`) over an in-memory SQLite database. A `User` entity (`Id`, `Name`, `Age`) is mapped via a `DbContext`, the schema is created with `EnsureCreated()`, and three rows are inserted with `DbSet.AddRange` / `SaveChanges`. Bob's row is loaded as a tracked entity with `Single`, its `Age` is set to 40, and `SaveChanges` issues the `UPDATE`. A LINQ query (`Where(u => u.Age >= 35).OrderBy(u => u.Id)`) then prints each matching row as `name age`.

## Run

    dotnet run
