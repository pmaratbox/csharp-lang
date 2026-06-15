using Microsoft.Extensions.DependencyInjection;
using HotChocolate.Execution;

var executor = await new ServiceCollection()
    .AddGraphQL()
    .AddQueryType<Query>()
    .BuildRequestExecutorAsync();

var result = await executor.ExecuteAsync("{ hello }");
var op = result.ExpectOperationResult();

Console.WriteLine(op.Data!["hello"]);

public class Query
{
    public string Hello() => "world";
}
