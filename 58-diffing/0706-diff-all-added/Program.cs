using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

// Diff an EMPTY list -> [x, y]. Every line is added.
var a = "";
var b = "x\ny";

var model = InlineDiffBuilder.Diff(a, b);

int added = 0;
foreach (var line in model.Lines)
{
    if (line.Type == ChangeType.Inserted) added++;
}

Console.WriteLine(added);
