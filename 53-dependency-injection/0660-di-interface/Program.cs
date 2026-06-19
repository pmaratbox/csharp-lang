using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IAnimal, Dog>();

var provider = services.BuildServiceProvider();

var animal = provider.GetRequiredService<IAnimal>();
Console.WriteLine(animal.Sound());   // woof

interface IAnimal { string Sound(); }
class Dog : IAnimal { public string Sound() => "woof"; }
