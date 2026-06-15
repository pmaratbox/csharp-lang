using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using var command = connection.CreateCommand();
command.CommandText = "select 42";

var result = command.ExecuteScalar();
Console.WriteLine(Convert.ToInt64(result));
