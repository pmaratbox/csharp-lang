using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using (var create = connection.CreateCommand())
{
    create.CommandText = "create table t(n integer)";
    create.ExecuteNonQuery();
}

// First transaction: insert 1 and 2, then commit.
using (var transaction = connection.BeginTransaction())
{
    using var insert = connection.CreateCommand();
    insert.Transaction = transaction;
    insert.CommandText = "insert into t values(1)";
    insert.ExecuteNonQuery();
    insert.CommandText = "insert into t values(2)";
    insert.ExecuteNonQuery();
    transaction.Commit();
}

// Second transaction: insert 3, then roll back so it disappears.
using (var transaction = connection.BeginTransaction())
{
    using var insert = connection.CreateCommand();
    insert.Transaction = transaction;
    insert.CommandText = "insert into t values(3)";
    insert.ExecuteNonQuery();
    transaction.Rollback();
}

using (var select = connection.CreateCommand())
{
    select.CommandText = "select n from t order by n";
    using var reader = select.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine(reader.GetInt32(0));
    }
}
