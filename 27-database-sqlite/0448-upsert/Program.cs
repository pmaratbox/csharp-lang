using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using (var create = connection.CreateCommand())
{
    create.CommandText = "create table inv(item text primary key, qty integer)";
    create.ExecuteNonQuery();
}

using (var seed = connection.CreateCommand())
{
    seed.CommandText = "insert into inv values($item, $qty)";
    seed.Parameters.AddWithValue("$item", "apple");
    seed.Parameters.AddWithValue("$qty", 5);
    seed.ExecuteNonQuery();
}

var upserts = new (string Item, int Qty)[] { ("apple", 5), ("banana", 3) };
foreach (var (item, qty) in upserts)
{
    using var upsert = connection.CreateCommand();
    upsert.CommandText =
        "insert into inv values($item, $qty) " +
        "on conflict(item) do update set qty = qty + excluded.qty";
    upsert.Parameters.AddWithValue("$item", item);
    upsert.Parameters.AddWithValue("$qty", qty);
    upsert.ExecuteNonQuery();
}

using (var select = connection.CreateCommand())
{
    select.CommandText = "select item, qty from inv order by item";
    using var reader = select.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"{reader.GetString(0)} {reader.GetInt32(1)}");
    }
}
