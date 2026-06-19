using Microsoft.Extensions.DependencyInjection;

var sc = new ServiceCollection();
sc.AddSingleton<IRepo, Repo>();
sc.AddTransient<Service>();
var sp = sc.BuildServiceProvider();

Console.WriteLine(sp.GetRequiredService<Service>().Run());

interface IRepo { string Data(); }
class Repo : IRepo { public string Data() => "data"; }
class Service(IRepo repo) { public string Run() => repo.Data(); }
