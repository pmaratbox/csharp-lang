using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

var a = "apple\nbanana\ncherry";
var b = "apple\nblueberry\ncherry\ndate";

var model = InlineDiffBuilder.Diff(a, b);

int added = 0;
foreach (var line in model.Lines)
{
    if (line.Type == ChangeType.Inserted) added++;
}

Console.WriteLine(added);
