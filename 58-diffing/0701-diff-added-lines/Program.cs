using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

// Diff A -> B with the real DiffPlex library, then collect the inserted lines.
var a = "apple\nbanana\ncherry";
var b = "apple\nblueberry\ncherry\ndate";

var model = InlineDiffBuilder.Diff(a, b);

var added = new List<string>();
foreach (var line in model.Lines)
{
    if (line.Type == ChangeType.Inserted)
        added.Add(line.Text);
}

// Added lines in document (B) order, comma-joined.
Console.WriteLine(string.Join(",", added));
