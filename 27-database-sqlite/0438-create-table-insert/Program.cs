using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using (var create = connection.CreateCommand())
{
    create.CommandText = "create table users(id integer, name text)";
    create.ExecuteNonQuery();
}

var rows = new (int Id, string Name)[] { (1, "alice"), (2, "bob"), (3, "carol") };
foreach (var (id, name) in rows)
{
    using var insert = connection.CreateCommand();
    insert.CommandText = "insert into users values($id, $name)";
    insert.Parameters.AddWithValue("$id", id);
    insert.Parameters.AddWithValue("$name", name);
    insert.ExecuteNonQuery();
}

using (var select = connection.CreateCommand())
{
    select.CommandText = "select name from users order by id";
    using var reader = select.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine(reader.GetString(0));
    }
}
