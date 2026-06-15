using Microsoft.Extensions.DependencyInjection;
using HotChocolate.Execution;

var executor = await new ServiceCollection()
    .AddGraphQL()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .BuildRequestExecutorAsync();

var result = await executor.ExecuteAsync("mutation { addUser(name: \"bob\") { name } }");
var op = result.ExpectOperationResult();

var user = (IReadOnlyDictionary<string, object?>)op.Data!["addUser"]!;
Console.WriteLine(user["name"]);

public class Query
{
    public string Hello() => "world";
}

public class Mutation
{
    public User AddUser(string name) => new User(name);
}

public record User(string Name);
