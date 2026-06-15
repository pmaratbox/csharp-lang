# 0458 — Join

Define `users(id, name)` and `posts(id, user_id, title)` entities, insert two users and three posts into an in-memory SQLite database, then join posts to users and print `name title` ordered by name then title. Uses Entity Framework Core (`Microsoft.EntityFrameworkCore.Sqlite`) with a `DbContext`, `DbSet<T>` entity sets, and LINQ's `Join` query operator over a shared open `SqliteConnection`.

## Run

    dotnet run
