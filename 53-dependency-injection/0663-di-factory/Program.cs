using Microsoft.Extensions.DependencyInjection;

var sc = new ServiceCollection();

// Register via a FACTORY function: the container invokes this lambda to
// construct the Widget instead of autowiring its constructor.
sc.AddSingleton<Widget>(sp => new Widget("built"));

var sp = sc.BuildServiceProvider();

Console.WriteLine(sp.GetRequiredService<Widget>().Value());

class Widget(string label)
{
    public string Value() => label;
}
