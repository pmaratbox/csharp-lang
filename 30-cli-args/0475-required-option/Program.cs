using CommandLine;

Parser.Default.ParseArguments<Options>(new[] { "--id", "42" })
    .WithParsed(o => Console.WriteLine(o.Id));

public class Options {
    [Option("id", Required = true)] public int Id { get; set; }
}
