using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IGreeter, Greeter>();

var provider = services.BuildServiceProvider();

var greeter = provider.GetRequiredService<IGreeter>();
Console.WriteLine(greeter.Greet());   // hello

interface IGreeter { string Greet(); }
class Greeter : IGreeter { public string Greet() => "hello"; }
