using CommandLine;

Parser.Default.ParseArguments<Options>(System.Array.Empty<string>())
    .WithParsed(o => Console.WriteLine(o.Count));

public class Options {
    [Option("count", Default = 1)] public int Count { get; set; }
}
