using CommandLine;

Parser.Default.ParseArguments<Options>(new[] { "--name", "alice" })
    .WithParsed(o => Console.WriteLine(o.Name));

public class Options
{
    [Option("name")] public string Name { get; set; } = "";
}
