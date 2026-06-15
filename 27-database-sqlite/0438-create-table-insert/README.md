# 0438 — Create table & insert

Create a `users(id integer, name text)` table in an in-memory SQLite database, insert three rows, then `select name from users order by id` and print each name on its own line. Uses Microsoft.Data.Sqlite with a `SqliteConnection`, parameterized `SqliteCommand` inserts, and a `SqliteDataReader` to iterate the result set.

## Run

    dotnet run
