using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using (var create = connection.CreateCommand())
{
    create.CommandText = "create table t(amount integer)";
    create.ExecuteNonQuery();
}

foreach (var amount in new[] { 10, 20, 30, 40, 50 })
{
    using var insert = connection.CreateCommand();
    insert.CommandText = "insert into t values($amount)";
    insert.Parameters.AddWithValue("$amount", amount);
    insert.ExecuteNonQuery();
}

using var select = connection.CreateCommand();
select.CommandText = "select count(*), sum(amount), min(amount), max(amount) from t";
using var reader = select.ExecuteReader();
while (reader.Read())
{
    for (var i = 0; i < reader.FieldCount; i++)
    {
        Console.WriteLine(reader.GetInt64(i));
    }
}
