# 0443 — Order by & limit

Sort descending and take the top rows. This lesson uses the Microsoft.Data.Sqlite driver to open a `Data Source=:memory:` connection, create a `scores` table, insert six integers, then run `select value from scores order by value desc limit 3` and print each returned value on its own line via a `SqliteDataReader`.

## Run

    dotnet run
