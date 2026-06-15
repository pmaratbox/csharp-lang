using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using (var create = connection.CreateCommand())
{
    create.CommandText =
        "create table users(id integer, name text);" +
        "create table orders(user_id integer, item text)";
    create.ExecuteNonQuery();
}

using (var insertUsers = connection.CreateCommand())
{
    insertUsers.CommandText = "insert into users(id, name) values($id, $name)";
    var idParam = insertUsers.CreateParameter();
    idParam.ParameterName = "$id";
    var nameParam = insertUsers.CreateParameter();
    nameParam.ParameterName = "$name";
    insertUsers.Parameters.Add(idParam);
    insertUsers.Parameters.Add(nameParam);

    foreach (var (id, name) in new[] { (1, "alice"), (2, "bob") })
    {
        idParam.Value = id;
        nameParam.Value = name;
        insertUsers.ExecuteNonQuery();
    }
}

using (var insertOrders = connection.CreateCommand())
{
    insertOrders.CommandText = "insert into orders(user_id, item) values($uid, $item)";
    var uidParam = insertOrders.CreateParameter();
    uidParam.ParameterName = "$uid";
    var itemParam = insertOrders.CreateParameter();
    itemParam.ParameterName = "$item";
    insertOrders.Parameters.Add(uidParam);
    insertOrders.Parameters.Add(itemParam);

    foreach (var (uid, item) in new[] { (1, "book"), (2, "pen"), (1, "lamp") })
    {
        uidParam.Value = uid;
        itemParam.Value = item;
        insertOrders.ExecuteNonQuery();
    }
}

using (var query = connection.CreateCommand())
{
    query.CommandText =
        "select u.name, o.item from orders o " +
        "join users u on u.id = o.user_id " +
        "order by u.name, o.item";
    using var reader = query.ExecuteReader();
    while (reader.Read())
    {
        var name = reader.GetString(0);
        var item = reader.GetString(1);
        Console.WriteLine($"{name} {item}");
    }
}
