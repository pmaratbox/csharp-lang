# 0437 — Connect & query

Open an in-memory SQLite database and run a single query. This lesson uses the Microsoft.Data.Sqlite driver to open a `Data Source=:memory:` connection, create a command for `select 42`, and prints the single integer result returned by `ExecuteScalar`.

## Run

    dotnet run
