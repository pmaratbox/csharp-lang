using Microsoft.Extensions.DependencyInjection;

var sc = new ServiceCollection();
sc.AddTransient<A>();
sc.AddTransient<B>();
sc.AddTransient<C>();
var sp = sc.BuildServiceProvider();

Console.WriteLine(sp.GetRequiredService<C>().V());

class A { public string V() => "a"; }
class B(A a) { public string V() => a.V() + "b"; }
class C(B b) { public string V() => b.V() + "c"; }
