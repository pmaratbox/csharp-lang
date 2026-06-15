using Microsoft.Extensions.DependencyInjection;
using HotChocolate.Execution;

var executor = await new ServiceCollection()
    .AddGraphQL().AddQueryType<Query>().BuildRequestExecutorAsync();

var request = OperationRequestBuilder.New()
    .SetDocument("query($id: Int!) { item(id: $id) { id } }")
    .SetVariableValues(new Dictionary<string, object?> { ["id"] = 42 })
    .Build();

var result = await executor.ExecuteAsync(request);
var op = result.ExpectOperationResult();

var item = (IReadOnlyDictionary<string, object?>)op.Data!["item"]!;
Console.WriteLine(item["id"]);

public class Query
{
    public Item GetItem(int id) => new(id);
}

public record Item(int Id);
