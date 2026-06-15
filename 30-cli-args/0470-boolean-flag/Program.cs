using CommandLine;

Parser.Default.ParseArguments<Options>(new[] { "--verbose" })
    .WithParsed(o => Console.WriteLine(o.Verbose ? "true" : "false"));

public class Options {
    [Option("verbose")] public bool Verbose { get; set; }
}
