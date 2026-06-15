using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using (var create = connection.CreateCommand())
{
    create.CommandText = "create table users(id integer, name text)";
    create.ExecuteNonQuery();
}

var names = new[] { "alice", "bob", "carol" };
using (var insert = connection.CreateCommand())
{
    insert.CommandText = "insert into users values($id, $name)";
    var idParam = insert.CreateParameter();
    idParam.ParameterName = "$id";
    var nameParam = insert.CreateParameter();
    nameParam.ParameterName = "$name";
    insert.Parameters.Add(idParam);
    insert.Parameters.Add(nameParam);
    for (var i = 0; i < names.Length; i++)
    {
        idParam.Value = i + 1;
        nameParam.Value = names[i];
        insert.ExecuteNonQuery();
    }
}

using (var update = connection.CreateCommand())
{
    update.CommandText = "update users set name='robert' where id=2";
    update.ExecuteNonQuery();
}

using (var delete = connection.CreateCommand())
{
    delete.CommandText = "delete from users where id=1";
    delete.ExecuteNonQuery();
}

using (var select = connection.CreateCommand())
{
    select.CommandText = "select id, name from users order by id";
    using var reader = select.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"{reader.GetInt32(0)} {reader.GetString(1)}");
    }
}
