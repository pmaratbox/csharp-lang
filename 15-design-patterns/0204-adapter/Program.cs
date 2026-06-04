using System.Globalization;

IFahrenheit adapter = new CelsiusToFahrenheitAdapter(new CelsiusSource(100));
Console.WriteLine(adapter.Fahrenheit.ToString(CultureInfo.InvariantCulture));

sealed class CelsiusSource
{
    public double Celsius { get; }
    public CelsiusSource(double celsius) => Celsius = celsius;
}

interface IFahrenheit { double Fahrenheit { get; } }

sealed class CelsiusToFahrenheitAdapter : IFahrenheit
{
    private readonly CelsiusSource _source;
    public CelsiusToFahrenheitAdapter(CelsiusSource source) => _source = source;
    public double Fahrenheit => _source.Celsius * 9 / 5 + 32;
}
