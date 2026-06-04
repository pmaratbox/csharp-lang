int[] nums = [1, 2, 3, 4, 1];
var taken = nums.TakeWhile(n => n < 3);
Console.WriteLine(string.Join(" ", taken));
