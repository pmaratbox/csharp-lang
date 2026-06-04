int[] nums = [2, 4, 6];
string allEven = nums.All(n => n % 2 == 0) ? "yes" : "no";
string anyOdd = nums.Any(n => n % 2 != 0) ? "yes" : "no";
Console.WriteLine($"{allEven} {anyOdd}");
