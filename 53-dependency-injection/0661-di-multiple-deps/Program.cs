using Microsoft.Extensions.DependencyInjection;

var sc = new ServiceCollection();
sc.AddSingleton<IA, A>();
sc.AddSingleton<IB, B>();
sc.AddTransient<Service>();
var sp = sc.BuildServiceProvider();

Console.WriteLine(sp.GetRequiredService<Service>().Run());

interface IA { string X(); }
interface IB { string Y(); }
class A : IA { public string X() => "a"; }
class B : IB { public string Y() => "b"; }
class Service(IA a, IB b) { public string Run() => a.X() + b.Y(); }
