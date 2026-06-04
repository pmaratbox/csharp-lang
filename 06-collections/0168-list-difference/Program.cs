int[] xs = [1, 2, 3, 4];
int[] remove = [2, 4];
var toRemove = remove.ToHashSet();

var diff = xs.Where(x => !toRemove.Contains(x));
Console.WriteLine(string.Join(" ", diff));
