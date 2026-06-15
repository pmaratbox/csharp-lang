# 0448 — Upsert

Create an `inv(item text primary key, qty integer)` table in an in-memory SQLite database, seed it with `('apple', 5)`, then run two upserts using `insert ... on conflict(item) do update set qty = qty + excluded.qty`: re-inserting `apple` adds to the existing quantity (becoming 10) while `banana` is inserted as a new row. Finally `select item, qty from inv order by item` and print each row as `item qty`. Uses Microsoft.Data.Sqlite with a `SqliteConnection`, parameterized `SqliteCommand` statements, and a `SqliteDataReader` to iterate the result set.

## Run

    dotnet run
