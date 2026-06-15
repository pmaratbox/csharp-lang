using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using HotChocolate.Execution;

var executor = await new ServiceCollection()
    .AddGraphQL().AddQueryType<Query>().BuildRequestExecutorAsync();
var result = await executor.ExecuteAsync("{ user { name age } }");
var op = result.ExpectOperationResult();

var user = (IReadOnlyDictionary<string, object?>)op.Data!["user"]!;
Console.WriteLine(user["name"]);
Console.WriteLine(user["age"]);

public class Query
{
    public User GetUser() => new User { Name = "alice", Age = 30 };
}

public class User
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
}
