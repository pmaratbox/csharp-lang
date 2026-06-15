using CommandLine;

var parser = new Parser(settings => settings.GetoptMode = true);
parser.ParseArguments<Options>(new[] { "--num", "1", "--num", "2", "--num", "3" })
    .WithParsed(o => Console.WriteLine(o.Num.Sum()));

public class Options
{
    [Option("num")] public IEnumerable<int> Num { get; set; } = Enumerable.Empty<int>();
}
