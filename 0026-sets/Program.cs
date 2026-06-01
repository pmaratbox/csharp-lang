HashSet<int> nums = new() { 1, 2, 2, 3 };
Console.WriteLine($"size: {nums.Count}");
Console.WriteLine($"has 2: {(nums.Contains(2) ? "yes" : "no")}");
Console.WriteLine($"has 5: {(nums.Contains(5) ? "yes" : "no")}");
