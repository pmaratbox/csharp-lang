using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

// Diff A against itself (A -> A). With identical inputs the LCS covers every
// line, so DiffPlex reports zero inserted and zero deleted lines.
var a = "apple\nbanana\ncherry";
var b = a;

var model = InlineDiffBuilder.Diff(a, b);

int added = 0;
int removed = 0;
foreach (var line in model.Lines)
{
    if (line.Type == ChangeType.Inserted) added++;
    else if (line.Type == ChangeType.Deleted) removed++;
}

Console.WriteLine($"{added} {removed}");
