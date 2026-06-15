# 0454 — Delete a row

Remove a persisted entity with Entity Framework Core over an in-memory SQLite database. After seeding three users, this lesson loads the user with `id=1` via a LINQ `Single`, removes it with `DbSet<User>.Remove`, and persists the deletion with `SaveChanges`. The remaining users are read back through the `Users` `DbSet` ordered by `Id` and their names are printed.

## Run

    dotnet run
