# 0439 — Parameterized query

Creates an in-memory SQLite table of users, inserts three rows with bound parameters, then runs `select name from users where id = $id` with the value 2 supplied as a real bound parameter (never string interpolation) and prints the resulting name. Uses the Microsoft.Data.Sqlite driver with `SqliteCommand` parameters.

## Run

    dotnet run
