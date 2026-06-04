int[] xs = [1, 1, 2, 3, 3, 3];

var runs = new List<List<int>>();
foreach (var x in xs)
{
    if (runs.Count == 0 || runs[^1][^1] != x)
        runs.Add([x]);
    else
        runs[^1].Add(x);
}

var formatted = runs.Select(run => string.Join(" ", run));
Console.WriteLine(string.Join("|", formatted));
