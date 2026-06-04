var a = Config.Instance;
var b = Config.Instance;
Console.WriteLine($"same: {(ReferenceEquals(a, b) ? "yes" : "no")}");

sealed class Config
{
    private static readonly Lazy<Config> instance = new(() => new Config());
    public static Config Instance => instance.Value;
    private Config() { }
}
