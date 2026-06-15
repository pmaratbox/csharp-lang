# 0446 — Indexes

Creates an in-memory SQLite table of products, inserts three rows, then executes `create index idx_sku on products(sku)` to build a real index before running `select price from products where sku = $sku` bound to 'B' and printing the resulting price. Uses the Microsoft.Data.Sqlite driver with `SqliteCommand` and a bound parameter.

## Run

    dotnet run
