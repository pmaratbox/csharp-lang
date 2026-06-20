using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

// Diff A -> B with the real DiffPlex library, then count line classifications.
var a = "apple\nbanana\ncherry";
var b = "apple\nblueberry\ncherry\ndate";

var model = InlineDiffBuilder.Diff(a, b);

int added = 0, removed = 0, unchanged = 0;
foreach (var line in model.Lines)
{
    if (line.Type == ChangeType.Inserted) added++;
    else if (line.Type == ChangeType.Deleted) removed++;
    else if (line.Type == ChangeType.Unchanged) unchanged++;
}

// Summary: "<added> <removed> <unchanged>".
Console.WriteLine($"{added} {removed} {unchanged}");
