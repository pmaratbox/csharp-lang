# 0441 — Aggregate functions

Creates an in-memory SQLite table `t`, inserts five integer amounts (10, 20, 30, 40, 50), then runs a single `select count(*), sum(amount), min(amount), max(amount) from t` and prints the four aggregate values, each on its own line. Uses the real Microsoft.Data.Sqlite driver with `SqliteConnection`, parameterized `SqliteCommand` inserts, and a `SqliteDataReader` to read the aggregate row.

## Run

    dotnet run
