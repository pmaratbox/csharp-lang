int[] xs = [1, 2, 3, 4];

var results = new List<int>();
var acc = 1;
foreach (var x in xs)
{
    acc *= x;
    results.Add(acc);
}

Console.WriteLine(string.Join(" ", results));
