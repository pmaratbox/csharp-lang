var nums = new[] { 1, 2, 3, 4 };
var sums = new List<int>();
int total = 0;
foreach (var n in nums)
{
    total += n;
    sums.Add(total);
}
Console.WriteLine(string.Join(" ", sums));
