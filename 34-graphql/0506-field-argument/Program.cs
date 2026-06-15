using Microsoft.Extensions.DependencyInjection;
using HotChocolate.Execution;

var executor = await new ServiceCollection()
    .AddGraphQL().AddQueryType<Query>().BuildRequestExecutorAsync();
var result = await executor.ExecuteAsync("{ greet(name: \"alice\") }");
var op = result.ExpectOperationResult();
Console.WriteLine(op.Data!["greet"]);

public class Query
{
    public string Greet(string name) => "hello " + name;
}
