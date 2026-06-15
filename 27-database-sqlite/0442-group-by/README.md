# 0442 — Group by

Aggregate amounts per group with SQL. This lesson uses the Microsoft.Data.Sqlite driver to open a `Data Source=:memory:` connection, create a `sales` table, insert rows via a prepared parameterized command, and run `select category, sum(amount) from sales group by category order by category`. It iterates the result set with a data reader and prints each group as `category sum` (space-separated).

## Run

    dotnet run
