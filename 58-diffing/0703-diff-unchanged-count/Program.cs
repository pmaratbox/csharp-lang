using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

var a = "apple\nbanana\ncherry";
var b = "apple\nblueberry\ncherry\ndate";

var model = InlineDiffBuilder.Diff(a, b);

int equal = 0;
foreach (var line in model.Lines)
{
    if (line.Type == ChangeType.Unchanged) equal++;
}

Console.WriteLine(equal);
