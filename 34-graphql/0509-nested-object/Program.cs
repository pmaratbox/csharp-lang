using Microsoft.Extensions.DependencyInjection;
using HotChocolate.Execution;

var executor = await new ServiceCollection()
    .AddGraphQL().AddQueryType<Query>().BuildRequestExecutorAsync();

var result = await executor.ExecuteAsync("{ user { address { city } } }");
var op = result.ExpectOperationResult();

var user = (IReadOnlyDictionary<string, object?>)op.Data!["user"]!;
var address = (IReadOnlyDictionary<string, object?>)user["address"]!;
Console.WriteLine(address["city"]);

public class Query
{
    public User GetUser() => new();
}

public class User
{
    public Address Address => new();
}

public class Address
{
    public string City => "oslo";
}
