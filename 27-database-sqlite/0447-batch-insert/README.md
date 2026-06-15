# 0447 — Batch insert

Create a `t(n integer)` table in an in-memory SQLite database, then insert 1000 rows (the values 1..1000) efficiently by reusing a single prepared `SqliteCommand` and rebinding its parameter inside one transaction. After committing, run `select count(*) from t` and print the resulting count. Uses Microsoft.Data.Sqlite with a `SqliteConnection`, a `SqliteTransaction`, a reused parameterized command, and `ExecuteScalar` for the count.

## Run

    dotnet run
