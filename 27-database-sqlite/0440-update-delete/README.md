# 0440 — Update & delete

Creates an in-memory SQLite database with a `users` table, inserts three rows, then runs an `UPDATE` to rename one row and a `DELETE` to remove another. It reads the remaining rows back with `SELECT ... ORDER BY id` and prints each as `id name`. Uses the Microsoft.Data.Sqlite driver with `SqliteConnection`, parameterized `SqliteCommand`, and a `SqliteDataReader`.

## Run

    dotnet run
