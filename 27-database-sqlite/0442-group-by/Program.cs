using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using (var create = connection.CreateCommand())
{
    create.CommandText = "create table sales(category text, amount integer)";
    create.ExecuteNonQuery();
}

using (var insert = connection.CreateCommand())
{
    insert.CommandText = "insert into sales(category, amount) values($category, $amount)";
    var categoryParam = insert.CreateParameter();
    categoryParam.ParameterName = "$category";
    var amountParam = insert.CreateParameter();
    amountParam.ParameterName = "$amount";
    insert.Parameters.Add(categoryParam);
    insert.Parameters.Add(amountParam);

    foreach (var (category, amount) in new[] { ("a", 10), ("b", 20), ("a", 30), ("b", 5), ("a", 2) })
    {
        categoryParam.Value = category;
        amountParam.Value = amount;
        insert.ExecuteNonQuery();
    }
}

using (var query = connection.CreateCommand())
{
    query.CommandText = "select category, sum(amount) from sales group by category order by category";
    using var reader = query.ExecuteReader();
    while (reader.Read())
    {
        var category = reader.GetString(0);
        var sum = reader.GetInt64(1);
        Console.WriteLine($"{category} {sum}");
    }
}
