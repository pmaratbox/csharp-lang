# 0444 — Inner join

Creates two in-memory SQLite tables, `users` and `orders`, inserts rows with bound parameters, then runs `select u.name, o.item from orders o join users u on u.id = o.user_id order by u.name, o.item` to combine each order with its owning user. Each joined row is printed as `name item`. Uses the Microsoft.Data.Sqlite driver with a `SqliteDataReader` for row iteration.

## Run

    dotnet run
