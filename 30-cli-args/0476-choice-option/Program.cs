using CommandLine;

var parser = new Parser(s => s.CaseInsensitiveEnumValues = true);
parser.ParseArguments<Options>(new[] { "--color", "green" })
    .WithParsed(o => Console.WriteLine(o.Color.ToString().ToLowerInvariant()));

public enum Color { Red, Green, Blue }

public class Options {
    [Option("color")] public Color Color { get; set; }
}
