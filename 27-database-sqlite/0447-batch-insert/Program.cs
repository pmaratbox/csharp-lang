using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using (var create = connection.CreateCommand())
{
    create.CommandText = "create table t(n integer)";
    create.ExecuteNonQuery();
}

using (var transaction = connection.BeginTransaction())
{
    using var insert = connection.CreateCommand();
    insert.CommandText = "insert into t(n) values($n)";
    var parameter = insert.CreateParameter();
    parameter.ParameterName = "$n";
    insert.Parameters.Add(parameter);

    for (var n = 1; n <= 1000; n++)
    {
        parameter.Value = n;
        insert.ExecuteNonQuery();
    }

    transaction.Commit();
}

using (var select = connection.CreateCommand())
{
    select.CommandText = "select count(*) from t";
    var count = (long)select.ExecuteScalar()!;
    Console.WriteLine(count);
}
