string[] letters = { "a", "b", "c" };
int[] nums = { 1, 2, 3 };
var pairs = letters.Zip(nums, (k, n) => $"{k}={n}");
Console.WriteLine(string.Join(" ", pairs));
