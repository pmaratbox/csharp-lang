var nums = new[] { 1, 2, 3, 4, 5 };
int k = 2;
var rotated = nums.Skip(k).Concat(nums.Take(k));
Console.WriteLine(string.Join(" ", rotated));
