using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

var a = "apple\nbanana\ncherry";
var b = "apple\nblueberry\ncherry\ndate";

var model = InlineDiffBuilder.Diff(a, b);

var removed = new List<string>();
foreach (var line in model.Lines)
{
    if (line.Type == ChangeType.Deleted)
        removed.Add(line.Text);
}

Console.WriteLine(string.Join(",", removed)); // banana
