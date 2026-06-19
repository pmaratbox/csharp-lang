using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IRepo, Repo>();

var provider = services.BuildServiceProvider();

var a = provider.GetRequiredService<IRepo>();
var b = provider.GetRequiredService<IRepo>();

Console.WriteLine(ReferenceEquals(a, b).ToString().ToLower());

interface IRepo { string Data(); }
class Repo : IRepo { public string Data() => "data"; }
