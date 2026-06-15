using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=:memory:");
connection.Open();

using (var create = connection.CreateCommand())
{
    create.CommandText = "create table products(id integer, sku text, price integer)";
    create.ExecuteNonQuery();
}

using (var insert = connection.CreateCommand())
{
    insert.CommandText = "insert into products(id, sku, price) values($id, $sku, $price)";
    var idParam = insert.CreateParameter();
    idParam.ParameterName = "$id";
    var skuParam = insert.CreateParameter();
    skuParam.ParameterName = "$sku";
    var priceParam = insert.CreateParameter();
    priceParam.ParameterName = "$price";
    insert.Parameters.Add(idParam);
    insert.Parameters.Add(skuParam);
    insert.Parameters.Add(priceParam);

    foreach (var (id, sku, price) in new[] { (1, "A", 100), (2, "B", 200), (3, "C", 300) })
    {
        idParam.Value = id;
        skuParam.Value = sku;
        priceParam.Value = price;
        insert.ExecuteNonQuery();
    }
}

using (var index = connection.CreateCommand())
{
    index.CommandText = "create index idx_sku on products(sku)";
    index.ExecuteNonQuery();
}

using (var query = connection.CreateCommand())
{
    query.CommandText = "select price from products where sku = $sku";
    query.Parameters.AddWithValue("$sku", "B");
    var result = (long)query.ExecuteScalar()!;
    Console.WriteLine(result);
}
