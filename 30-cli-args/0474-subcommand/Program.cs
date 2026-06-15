using CommandLine;

Parser.Default.ParseArguments<AddOptions, SubOptions>(new[] { "add", "2", "3" })
    .WithParsed<AddOptions>(o => Console.WriteLine(o.X + o.Y))
    .WithParsed<SubOptions>(o => Console.WriteLine(o.X - o.Y));

[Verb("add", HelpText = "Add two integers.")]
public class AddOptions
{
    [Value(0, MetaName = "x", Required = true)]
    public int X { get; set; }

    [Value(1, MetaName = "y", Required = true)]
    public int Y { get; set; }
}

[Verb("sub", HelpText = "Subtract two integers.")]
public class SubOptions
{
    [Value(0, MetaName = "x", Required = true)]
    public int X { get; set; }

    [Value(1, MetaName = "y", Required = true)]
    public int Y { get; set; }
}
