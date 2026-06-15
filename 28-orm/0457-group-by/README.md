# 0457 — Group by

Aggregate per group via the query API. This lesson uses Entity Framework Core (`Microsoft.EntityFrameworkCore.Sqlite`) over an in-memory SQLite database. A `Product` entity (id, category, price) is mapped through a `DbContext`, and `EnsureCreated()` builds the schema from the model. After inserting rows with `AddRange`/`SaveChanges`, the LINQ provider's `GroupBy(p => p.Category)` plus `Select(g => g.Sum(p => p.Price))` and `OrderBy` translate to a SQL `GROUP BY ... ORDER BY`, printing each group as `category sum`.

## Run

    dotnet run
