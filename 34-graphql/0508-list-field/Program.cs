using System.Collections;
using Microsoft.Extensions.DependencyInjection;
using HotChocolate.Execution;

var executor = await new ServiceCollection()
    .AddGraphQL().AddQueryType<Query>().BuildRequestExecutorAsync();
var result = await executor.ExecuteAsync("{ numbers }");
var op = result.ExpectOperationResult();
foreach (var n in (IEnumerable)op.Data!["numbers"]!)
    Console.WriteLine(n);

public class Query
{
    public int[] Numbers() => new[] { 1, 2, 3 };
}
