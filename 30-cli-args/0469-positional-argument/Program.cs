using CommandLine;

Parser.Default.ParseArguments<Options>(new[] { "alice" })
    .WithParsed(o => Console.WriteLine(o.Name));

public class Options
{
    [Value(0, MetaName = "name", Required = true)]
    public string Name { get; set; } = "";
}
