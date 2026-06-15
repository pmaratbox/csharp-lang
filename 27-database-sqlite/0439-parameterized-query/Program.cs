using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using (var create = connection.CreateCommand())
{
    create.CommandText = "create table users(id integer, name text)";
    create.ExecuteNonQuery();
}

using (var insert = connection.CreateCommand())
{
    insert.CommandText = "insert into users(id, name) values($id, $name)";
    var idParam = insert.CreateParameter();
    idParam.ParameterName = "$id";
    var nameParam = insert.CreateParameter();
    nameParam.ParameterName = "$name";
    insert.Parameters.Add(idParam);
    insert.Parameters.Add(nameParam);

    foreach (var (id, name) in new[] { (1, "alice"), (2, "bob"), (3, "carol") })
    {
        idParam.Value = id;
        nameParam.Value = name;
        insert.ExecuteNonQuery();
    }
}

using (var query = connection.CreateCommand())
{
    query.CommandText = "select name from users where id = $id";
    query.Parameters.AddWithValue("$id", 2);
    var result = (string)query.ExecuteScalar()!;
    Console.WriteLine(result);
}
