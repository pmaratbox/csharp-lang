using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using (var create = connection.CreateCommand())
{
    create.CommandText = "create table scores(value integer)";
    create.ExecuteNonQuery();
}

using (var insert = connection.CreateCommand())
{
    insert.CommandText = "insert into scores(value) values($value)";
    var valueParam = insert.CreateParameter();
    valueParam.ParameterName = "$value";
    insert.Parameters.Add(valueParam);

    foreach (var value in new[] { 50, 90, 70, 30, 100, 20 })
    {
        valueParam.Value = value;
        insert.ExecuteNonQuery();
    }
}

using (var query = connection.CreateCommand())
{
    query.CommandText = "select value from scores order by value desc limit 3";
    using var reader = query.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine(reader.GetInt64(0));
    }
}
