# 0445 — Transactions

Creates an in-memory SQLite database with a `t(n integer)` table, then demonstrates real transaction control. A first transaction inserts `1` and `2` and is committed, while a second transaction inserts `3` and is rolled back so that change is discarded. A final `SELECT n FROM t ORDER BY n` confirms only `1` and `2` remain. Uses the Microsoft.Data.Sqlite driver with `SqliteConnection.BeginTransaction`, `Commit`, and `Rollback`.

## Run

    dotnet run
