using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton(new Config("v1"));   // register a constant value instance
services.AddTransient<Service>();

var provider = services.BuildServiceProvider();

var service = provider.GetRequiredService<Service>();
Console.WriteLine(service.Read());   // v1

record Config(string Value);
class Service(Config config) { public string Read() => config.Value; }
