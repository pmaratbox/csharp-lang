using Microsoft.Extensions.DependencyInjection;
using HotChocolate.Execution;

var executor = await new ServiceCollection()
    .AddGraphQL().AddQueryType<Query>().BuildRequestExecutorAsync();

var result = await executor.ExecuteAsync("{ user { name } }");
var op = result.ExpectOperationResult();

var user = (IReadOnlyDictionary<string, object?>)op.Data!["user"]!;
Console.WriteLine(user["name"]);

public class Query
{
    public User GetUser() => new User("alice");
}

public record User(string Name);
